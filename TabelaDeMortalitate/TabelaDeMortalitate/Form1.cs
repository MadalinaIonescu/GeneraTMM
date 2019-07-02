using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO.Compression;
using System.Threading;

namespace TabelaDeMortalitate
{
    public partial class Form1 : Form
    {
        private HttpWebRequestWithFile requestPopulation;
        private HttpWebRequestWithFile requestMortality;
        private HttpWebRequestWithFile requestNewBorns;
        public Form1()
        {
            InitializeComponent();
            InitializeLoading();
           

            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
            int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
            this.Location = new Point((screen.Width - w) / 2, (screen.Height - h) / 2);
            this.Size = new Size(w, h);
        }

        private void InitializeLoading()
        {
            btnInputINS.Enabled = false;
            btnInsert.Enabled = false;
            btnGenerateTable.Enabled = false;
            btnGenerateGraphic.Enabled = false;

            progressBar.Visible = true;
            progressBar.Minimum = 0;
            progressBar.Maximum = 3;
            progressBar.Step = 1;
        }

        private void FinishLoading()
        {
            btnInputINS.Invoke(new Action(()=> btnInputINS.Enabled = true));
            btnInsert.Invoke(new Action(() => btnInsert.Enabled = true));
            btnGenerateTable.Invoke(new Action(() => btnGenerateTable.Enabled = true));
            btnGenerateGraphic.Invoke(new Action(() => btnGenerateGraphic.Enabled = true));

            progressBar.Invoke(new Action(() => progressBar.Visible = false));
            mainPanel.Invoke(new Action(() => mainPanel.Controls.Clear() ));

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            ReadExcel readExcel = new ReadExcel();
            readExcel.GetExcelDataFromComputer();
            if (readExcel.Status == true)
            {
                lblStatusExcel.Text = "Ati incarcat fisierul " + readExcel.FileName;
                btnExcludeExcel.Visible = true;
            }

        }

        private void btnExcludeExcel_Click(object sender, EventArgs e)
        {
            StructureExcel.MaxAge = 0;
            StructureExcel.PopulationYear2.Clear();
            StructureExcel.PopulationYear3.Clear();
            StructureExcel.PopulationAverage.Clear();
            StructureExcel.MortalitysFirstYear.Clear();
            StructureExcel.MortalitysSecondYear.Clear();
            StructureExcel.MortalitysThirdYear.Clear();

            lblStatusExcel.Text = "Niciun fisier incarcat";
            btnExcludeExcel.Visible = false;
            mainPanel.Controls.Clear();


        }

        private void btnGenerateTable_Click(object sender, EventArgs e)
        {
            if (StructureExcel.MaxAge != 0)
            {
                mainPanel.Controls.Clear();
                CreateOutputFormat createOutputFormat = new CreateOutputFormat();
                createOutputFormat.createOutput();
                Tabela tabela = new Tabela();
                tabela.Show();
            //    CreateOutputFormat createOutputFormat = new CreateOutputFormat();
            //    createOutputFormat.createOutput();
            //    Tabela tabela = new Tabela(mainPanel.Width, mainPanel.Height, mainPanel.Location);
            //    mainPanel.Controls.Clear();
            //    tabela.TopLevel = false;
            //    tabela.AutoScroll = true;
            //    tabela.FormBorderStyle = FormBorderStyle.None;
            //    mainPanel.Controls.Add(tabela);
            //    tabela.Show();
            }
            else
            {
                MessageBox.Show("Incarcati intai un fisier", "Atentionare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGenerateGraphic_Click(object sender, EventArgs e)
        {
            if (StructureExcel.MaxAge != 0)
            {
                mainPanel.Controls.Clear();
                CreateOutputFormat createOutputFormat = new CreateOutputFormat();
                createOutputFormat.createOutput();
                Graphics grafic = new Graphics();
                grafic.Show();
                //CreateOutputFormat createOutputFormat = new CreateOutputFormat();
                //createOutputFormat.createOutput();
                //Graphics grafic = new Graphics();
                //mainPanel.Controls.Clear();
                //grafic.TopLevel = false;
                //grafic.AutoScroll = true;
                //grafic.FormBorderStyle = FormBorderStyle.None;
                //mainPanel.Controls.Add(grafic);
                //grafic.Show();

            }
            else
            {
                MessageBox.Show("Incarcati intai un fisier", "Atentionare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnInputINS_Click(object sender, EventArgs e)
        {
            InputForm input = new InputForm();
            mainPanel.Controls.Clear();
            input.TopLevel = false;
            input.AutoScroll = true;
            input.FormBorderStyle = FormBorderStyle.None;
            mainPanel.Controls.Add(input);
            input.Show();
        }

        private void btnGenerateGraphic_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                if (StructureExcel.MaxAge != 0)
                {
                    CreateOutputFormat createOutputFormat = new CreateOutputFormat();
                    createOutputFormat.createOutput();
                    Graphics grafic = new Graphics();
                    grafic.Show();
                }
                else
                {
                    MessageBox.Show("Incarcati intai un fisier", "Atentionare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void btnGenerateTable_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (StructureExcel.MaxAge != 0)
                {
                    CreateOutputFormat createOutputFormat = new CreateOutputFormat();
                    createOutputFormat.createOutput();
                    Tabela tabela = new Tabela();
                    tabela.Show();
                }
                else
                {
                    MessageBox.Show("Incarcati intai un fisier", "Atentionare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                requestPopulation = new HttpWebRequestWithFile();
                requestPopulation.Request = (HttpWebRequest)WebRequest.Create("https://ec.europa.eu/eurostat/estat-navtree-portlet-prod/BulkDownloadListing?file=data/demo_pjan.tsv.gz");
                requestPopulation.Request.Accept = "*/*";
                requestPopulation.Request.Host = "ec.europa.eu";
                requestPopulation.FileName = "population.txt";
                requestPopulation.Delay = 1000;
                requestPopulation.Request.BeginGetResponse(new AsyncCallback(FinishWebRequest), requestPopulation);

                requestMortality = new HttpWebRequestWithFile();
                requestMortality.Request = (HttpWebRequest)WebRequest.Create("https://ec.europa.eu/eurostat/estat-navtree-portlet-prod/BulkDownloadListing?file=data/demo_magec.tsv.gz");
                requestMortality.Request.Accept = "*/*";
                requestMortality.Request.Host = "ec.europa.eu";
                requestMortality.FileName = "mortality.txt";
                requestMortality.Delay = 1500;
                requestMortality.Request.BeginGetResponse(new AsyncCallback(FinishWebRequest), requestMortality);

                requestNewBorns = new HttpWebRequestWithFile();
                requestNewBorns.Request = (HttpWebRequest)WebRequest.Create("https://ec.europa.eu/eurostat/estat-navtree-portlet-prod/BulkDownloadListing?file=data/demo_fasec.tsv.gz");
                requestNewBorns.Request.Accept = "*/*";
                requestNewBorns.Request.Host = "ec.europa.eu";
                requestNewBorns.FileName = "newBorns.txt";
                requestNewBorns.Delay = 2000;
                requestNewBorns.Request.BeginGetResponse(new AsyncCallback(FinishWebRequest), requestNewBorns);
            }

            catch(Exception ex)
            {
                try
                {
                    FinishLoading();
                }
                catch (Exception ex1)
                {
                }
                this.Invoke(new Action(() => MessageBox.Show("Nu s-a putut realiza conexiunea cu baza de date EUROSTAT!", "Atentionare", MessageBoxButtons.OK, MessageBoxIcon.Warning)));

            }

        }

        void FinishWebRequest(IAsyncResult result)
        {
            HttpWebRequestWithFile request = result.AsyncState as HttpWebRequestWithFile;
            HttpWebResponse response = request.Request.EndGetResponse(result) as HttpWebResponse;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                using (Stream fd = File.Create(request.FileName))
                using (Stream responseStream = new GZipStream(response.GetResponseStream(), CompressionMode.Decompress))
                {
                    byte[] buffer = new byte[1024];
                    int nRead;
                    while ((nRead = responseStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        fd.Write(buffer, 0, nRead);
                    }
                   //Invoke(new EventHandle{progressBar.Value++;});

                    Thread.Sleep(request.Delay);
                    progressBar.Invoke(new Action(() => progressBar.Value++));
                    if (progressBar.Value == progressBar.Maximum)
                    {
                        Thread.Sleep(1000);
                        FinishLoading();
                    }
                    
                }
            }
            else
            {
                MessageBox.Show( "Nu s-a putut incarca populatia", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}

