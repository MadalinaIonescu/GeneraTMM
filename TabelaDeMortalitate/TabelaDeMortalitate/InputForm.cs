using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TabelaDeMortalitate
{
    public partial class InputForm : Form
    {
        private string selectedSex;
        private int selectedFirstYear;
        private string selectedcountryCode;

        public List<PopulationEntry> populations = new List<PopulationEntry>();
        public List<MortalityEntry> mortalitys = new List<MortalityEntry>();
        public NewBornEntry newBorns = new NewBornEntry();


        public Dictionary<string, string> countries = new Dictionary<string, string>
        {
            {"EU28","European Union - 28 countries"},
	        {"BE"  ,"Belgium"},
	        {"BG"  ,"Bulgaria"},
	        {"CZ","Czechia"},
	        {"DK","Denmark"},
	        {"DE_TOT","Germany"},
	        {"EE","Estonia"},
	        {"IE","Ireland"},
	        {"EL","Greece"},
	        {"ES","Spain"},
	        {"FR","France"},
	        {"HR","Croatia"},
	        {"IT","Italy"},
	        {"CY","Cyprus"},
	        {"LV","Latvia"},
	        {"LT","Lithuania"},
	        {"LU","Luxembourg"},
	        {"HU","Hungary"},
	        {"MT","Malta"},
	        {"NL","Netherlands"},
	        {"AT","Austria"},
	        {"PL","Poland"},
	        {"PT","Portugal"},
	        {"RO","Romania"},
	        {"SI","Slovenia"},
	        {"SK","Slovakia"},
	        {"FI","Finland"},
	        {"SE","Sweden"},
	        {"UK","United Kingdom"},
	        {"IS","Iceland"},
	        {"LI","Liechtenstein"},
	        {"NO","Norway"},
	        {"CH","Switzerland"},
	        {"ME","Montenegro"},
	        {"MK","North Macedonia"},
	        {"AL","Albania"},
	        {"RS","Serbia"},
	        {"TR","Turkey"},
	        {"AD","Andorra"},
	        {"BY","Belarus"},
	        {"BA","Bosnia and Herzegovina"},
	        {"XK","Kosovo"},
	        {"MD","Moldova"},
	        {"RU","Russia"},
	        {"SM","San Marino"},
	        {"UA","Ukraine"},
	        {"AM","Armenia"},
	        {"AZ","Azerbaijan"},
	        {"GE","Georgia"}

        };
        public InputForm()
        {
            InitializeComponent();

            cbSex.SelectedIndex = 2;
            for (int i = 2008; i <= 2015; i++)
            {
                cbAn1.Items.Add(i);
            }
            cbAn1.SelectedIndex = 0;
            tbAnFinal.Text = (Convert.ToInt32(cbAn1.SelectedItem) + 2).ToString();
            foreach (string code in countries.Values)
            {
                cbCountry.Items.Add(code);
            }
            cbCountry.SelectedIndex = cbCountry.Items.IndexOf("Romania");
        }

        private void cbAn1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbAnFinal.Text = (Convert.ToInt32(cbAn1.SelectedItem) + 2).ToString();
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
            int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
            this.Location = new Point((screen.Width - w) / 2, (screen.Height - h) / 2);
            this.Size = new Size(w, h);
        }

        private string RemoveSpecificCharacters(string s)
        {
            return s.Trim().Replace("/s","").Replace("/sb","").Replace("/sc","").Replace("/sd","")
                           .Replace("/se","").Replace("/sf","").Replace("/sn","")
                           .Replace("/sp","").Replace("/sr","").Replace("/ss","")
                           .Replace("/su","").Replace("/sz","");
        }
        private void CreateEntryForPopulationFromFile(string fileName)
        {
            Dictionary<string, int> columns = new Dictionary<string, int>();
            int counter = 0;
            StreamReader file = new StreamReader(fileName);
            string line;
            string header = file.ReadLine();

            foreach (string t in header.Split(',', '\t'))
            {
                columns.Add(t.Trim().Replace(" ",""), counter);
                counter++;
            }
            while ((line = file.ReadLine()) != null)
            {
                String[] cells = line.Split(',', '\t');
                if (cells[columns["sex"]].Trim().Replace(",", "") == selectedSex && cells[columns["geo\\time"]].Trim().Replace(",", "") == selectedcountryCode)
                {
                    PopulationEntry entry = new PopulationEntry();
                    entry.StrAge = cells[columns["age"]].Trim().Replace(",", "");
                    if (entry.StrAge != "TOTAL" && entry.StrAge != "UNK")
                    {
                        if (entry.StrAge == "Y_LT1")
                            entry.IntAge = 0;
                        else
                            if (entry.StrAge == "Y_OPEN")
                                entry.IntAge = 100;
                            else
                                entry.IntAge = Convert.ToInt32(entry.StrAge.Substring(1));
                        int n;
                        string secondYear = RemoveSpecificCharacters(cells[columns[(selectedFirstYear + 1).ToString()]]);
                        if (int.TryParse(secondYear, out  n) == true)
                        {
                            entry.PopulationValueYear2 = Convert.ToInt32(secondYear);
                        }
                        else
                        {
                            entry.PopulationValueYear2 = -1;
                        }

                        string thirdYear = RemoveSpecificCharacters(cells[columns[(selectedFirstYear + 2).ToString()]]);
                        if (int.TryParse(thirdYear, out  n) == true)
                        {
                            entry.PopulationValueYear3 = Convert.ToInt32(thirdYear);
                        }
                        else
                        {
                            entry.PopulationValueYear3 = -1;
                        }
                        populations.Add(entry);
                    }
                }
            }
            file.Close();
        }

        private void CreateEntryForMortalityFromFile(string fileName)
        {
            Dictionary<string, int> columns = new Dictionary<string, int>();
            int counter = 0;
            StreamReader file = new StreamReader(fileName);
            string line;
            string header = file.ReadLine();

            foreach (string t in header.Split(',', '\t'))
            {
                columns.Add(t.Trim().Replace(" ", ""), counter);
                counter++;
            }
            while ((line = file.ReadLine()) != null)
            {
                String[] cells = line.Split(',', '\t');
                if (cells[columns["sex"]].Trim().Replace(",", "") == selectedSex && cells[columns["geo\\time"]].Trim().Replace(",", "") == selectedcountryCode)
                {
                    MortalityEntry entry = new MortalityEntry();
                    entry.StrAge = cells[columns["age"]].Trim().Replace(",", "");

                    if (entry.StrAge != "TOTAL" && entry.StrAge != "UNK")
                    {
                        if (entry.StrAge == "Y_LT1")
                            entry.IntAge = 0;
                        else
                            if (entry.StrAge == "Y_OPEN")
                                entry.IntAge = 100;
                        else
                                entry.IntAge = Convert.ToInt32(entry.StrAge.Substring(1));
                        int n;
                        string firstYear = RemoveSpecificCharacters(cells[columns[(selectedFirstYear).ToString()]]);
                        if (int.TryParse(firstYear, out  n) == true)
                        {
                            entry.MortalityValueYear1 = Convert.ToInt32(firstYear);
                        }
                        else
                        {
                            entry.MortalityValueYear1 = -1;
                        }

                        string secondYear = RemoveSpecificCharacters(cells[columns[(selectedFirstYear + 1).ToString()]]);
                        if (int.TryParse(secondYear, out  n) == true)
                        {
                            entry.MortalityValueYear2 = Convert.ToInt32(secondYear);
                        }
                        else
                        {
                            entry.MortalityValueYear2 = -1;
                        }

                        string thirdYear = RemoveSpecificCharacters(cells[columns[(selectedFirstYear + 2).ToString()]]);
                        if (int.TryParse(thirdYear, out  n) == true)
                        {
                            entry.MortalityValueYear3 = Convert.ToInt32(thirdYear);
                        }
                        else
                        {
                            entry.MortalityValueYear3 = -1;
                        }
                        mortalitys.Add(entry);
                    }
                }
            }
            file.Close();
        }

        private void CreateEntryForNewBornsFromFile(string fileName)
        {
            Dictionary<string, int> columns = new Dictionary<string, int>();
            int counter = 0;
            StreamReader file = new StreamReader(fileName);
            string line;
            string header = file.ReadLine();

            foreach (string t in header.Split(',', '\t'))
            {
                columns.Add(t.Trim().Replace(" ", ""), counter);
                counter++;
            }
            int ok = 0;
            while ((line = file.ReadLine()) != null && ok == 0)
            {
                String[] cells = line.Split(',', '\t');
                if (cells[columns["geo\\time"]].Trim().Replace(",", "") == selectedcountryCode)
                {
                    ok = 1;
                    newBorns  = new NewBornEntry();

                    int n;
                    string precedingYear = RemoveSpecificCharacters(cells[columns[(selectedFirstYear - 1).ToString()]]);
                    if (int.TryParse(precedingYear, out  n) == true)
                    {
                        newBorns.NewBornsYear0 = Convert.ToInt32(precedingYear);
                    }
                    else
                    {
                        newBorns.NewBornsYear0 = -1;
                    }

                    string firstYear = RemoveSpecificCharacters(cells[columns[(selectedFirstYear + 2).ToString()]]);
                    if (int.TryParse(firstYear, out  n) == true)
                    {
                        newBorns.NewBornsYear1 = Convert.ToInt32(firstYear);
                    }
                    else
                    {
                        newBorns.NewBornsYear1 = -1;
                    }

                    string secondYear = RemoveSpecificCharacters(cells[columns[(selectedFirstYear + 1).ToString()]]);
                    if (int.TryParse(secondYear, out  n) == true)
                    {
                        newBorns.NewBornsYear2 = Convert.ToInt32(secondYear);
                    }
                    else
                    {
                        newBorns.NewBornsYear2 = -1;
                    }

                    string thirdYear = RemoveSpecificCharacters(cells[columns[(selectedFirstYear + 2).ToString()]]);
                    if (int.TryParse(thirdYear, out  n) == true)
                    {
                        newBorns.NewBornsYear3 = Convert.ToInt32(thirdYear);
                    }
                    else
                    {
                        newBorns.NewBornsYear3 = -1;
                    }
                }
            }
            file.Close();
        }


        private void btnCerere_Click(object sender, EventArgs e)
        {
            selectedFirstYear = Convert.ToInt32(cbAn1.Text);
            selectedSex = cbSex.Text;
            selectedcountryCode = countries.Where(x => x.Value == cbCountry.Text).Select(x=>x.Key).FirstOrDefault();
            RemoveItemsFromLists();
            try 
            {
                CreateEntryForPopulationFromFile("population.txt");
                populations = populations.OrderBy(x => x.IntAge).ToList();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fisierul populations.txt nu are formatul asteptat sau nu există", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                CreateEntryForMortalityFromFile("mortality.txt");
                mortalitys = mortalitys.OrderBy(x => x.IntAge).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fisierul mortality.txt nu are formatul asteptat sau nu există", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                CreateEntryForNewBornsFromFile("newBorns.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fisierul newBoorns.txt nu are formatul asteptat sau nu există", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            WriteExcel write = new WriteExcel();
            write.FileName = GetWrittenSelectedSex() + ", " + countries[selectedcountryCode] + ", " + selectedFirstYear + "-" + (selectedFirstYear + 2).ToString();
            try
            {
                if (populations.Count == 0 && mortalitys.Count == 0 && newBorns.CheckForNoData())
                    throw new Exception();
                else
                {
                write.WriteToExcel(populations, mortalitys, newBorns);
                DialogResult result = MessageBox.Show(string.Format("Ati creat fesierul {0}!", write.FileName + ".xlsx \r\nDoriti sa il incarcati?"), "Felicitari", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Form1 master = (Form1)Application.OpenForms["Form1"];
                    ReadExcel readExcel = new ReadExcel();
                    readExcel.GetExcelDataAlreadyCreated(write.FileName + ".xlsx");
                    if (readExcel.Status == true)
                    {
                        master.lblStatusExcel.Text = "Ati incarcat fisierul " + readExcel.FileName;
                        master.btnExcludeExcel.Visible = true;
                    }
                }
            }

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Fisierul {0} nu s-a putut crea!", write.FileName + ".xlsx"), "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void RemoveItemsFromLists()
        {
            populations.Clear();
            mortalitys.Clear();
        }

        private string GetWrittenSelectedSex()
        {
            if (selectedSex == "F")
                return "Femei";
            else
                if (selectedSex == "M")
                    return "Barbati";
                else
                    return "TOTAL";
        }

    }
}
