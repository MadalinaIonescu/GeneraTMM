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

namespace TabelaDeMortalitate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            ReadExcel readExcel = new ReadExcel();
            readExcel.getExcelData();
            if(readExcel.Status==true)
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

        }

        private void btnGenerateTable_Click(object sender, EventArgs e)
        {
            if (StructureExcel.MaxAge != 0)
            {
                CreateOutputFormat createOutputFormat = new CreateOutputFormat();
                createOutputFormat.createOutput();
                Tabela tabela = new Tabela();
                tabela.ShowDialog();
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
                CreateOutputFormat createOutputFormat = new CreateOutputFormat();
                createOutputFormat.createOutput();
                Graphics grafic = new Graphics();
                grafic.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incarcati intai un fisier", "Atentionare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

     

      

     

      
    }
}
