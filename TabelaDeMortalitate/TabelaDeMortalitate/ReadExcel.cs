using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabelaDeMortalitate
{
   public  class ReadExcel
    {
        Boolean status = false;
       public static String fileName;

        public String FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        public Boolean Status
        {
            get { return status; }
            
        }


        public void ReadExcelData(IExcelDataReader reader, bool isFromComputer)
        {
            int ok = -1;
            try
            {
                StructureExcel.MaxAge = 0;
                StructureExcel.PopulationYear2.Clear();
                StructureExcel.PopulationYear3.Clear();
                StructureExcel.PopulationAverage.Clear();
                StructureExcel.MortalitysFirstYear.Clear();
                StructureExcel.MortalitysSecondYear.Clear();
                StructureExcel.MortalitysThirdYear.Clear();

                while (reader.Read())
                {
                    ok++;
                    if (ok == 0)
                    {

                    }

                    else
                    {
                        int[] values = new int[11];
                        Console.Write(reader.GetDouble(1) + " ");
                        StructureExcel.PopulationYear2.Add(values[0] = (int)reader.GetDouble(1));
                        StructureExcel.PopulationYear3.Add(values[1] = (int)reader.GetDouble(2));
                        StructureExcel.MortalitysFirstYear.Add(values[2] = (int)reader.GetDouble(3));
                        StructureExcel.MortalitysSecondYear.Add(values[3] = (int)reader.GetDouble(4));
                        StructureExcel.MortalitysThirdYear.Add(values[4] = (int)reader.GetDouble(5));

                        Console.Write(reader.GetDouble(2) + " ");
                        Console.Write(reader.GetDouble(3) + " ");
                        Console.Write(reader.GetDouble(4) + " ");
                        Console.Write(reader.GetDouble(5) + " ");
                        Console.WriteLine();

                        if (ok == 1 && reader.FieldCount == 10)
                        {
                            StructureExcel.NewBorns[0] = values[5] = (int)reader.GetDouble(6);
                            StructureExcel.NewBorns[1] = values[6] = (int)reader.GetDouble(7);
                            StructureExcel.NewBorns[2] = values[7] = (int)reader.GetDouble(8);
                            StructureExcel.NewBorns[3] = values[8] = (int)reader.GetDouble(9);


                            Console.WriteLine("New borns10 ");
                            Console.WriteLine(StructureExcel.NewBorns[0]);
                            Console.WriteLine(StructureExcel.NewBorns[1]);
                            Console.WriteLine(StructureExcel.NewBorns[2]);
                            Console.WriteLine(StructureExcel.NewBorns[3]);

                        }
                        else
                            if (ok == 1 && reader.FieldCount == 9)
                            {
                                StructureExcel.NewBorns[0] = values[5] = (int)reader.GetDouble(6);
                                StructureExcel.NewBorns[1] = values[6] = (int)reader.GetDouble(7);
                                StructureExcel.NewBorns[2] = values[7] = (int)reader.GetDouble(8);
                                StructureExcel.NewBorns[3] = 0;

                                Console.WriteLine("New borns9 ");
                                Console.WriteLine(StructureExcel.NewBorns[0]);
                                Console.WriteLine(StructureExcel.NewBorns[1]);
                                Console.WriteLine(StructureExcel.NewBorns[2]);
                                Console.WriteLine(StructureExcel.NewBorns[3]);

                            }
                            else
                                if (ok == 1)
                                    throw new Exception();
                        for (int i = 0; i < 11; i++)
                        {
                            if (values[i] < 0)
                                throw new ExceptionMissingValue();
                        }
                    }

                }
                Console.WriteLine(ok);
                if(ok!= 101)
                    throw new Exception();
                StructureExcel.setPopulationAverage();
                StructureExcel.MaxAge = ok - 1;
                status = true;


            }
            catch (ExceptionMissingValue ex)
            {
                status = false;
                MessageBox.Show("Fisierul contine valori lipsa si nu s-a putut incarca!\r\nAcest lucru s-a produs automat datorita datelor lipsa\r\nCorectati valorile negative cu valori aproximate.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                status = false;
                if(isFromComputer)
                    MessageBox.Show("Fisierul nu are formatul corect!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Fisierul nu are formatul corect! Corectati valorile lipsa!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //6. Free resources (IExcelDataReader is IDisposable)
            reader.Close();
        }
       public void GetExcelDataFromComputer()
       {
           
           using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook 97-2003|*.xls| Excel Workbook|*.xlsx" })
           {
               if (ofd.ShowDialog() == DialogResult.OK)
               {
                   FileStream fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read);
                   fileName = ofd.SafeFileName;
                   IExcelDataReader reader;
                   if (ofd.FilterIndex == 1)
                       reader = ExcelReaderFactory.CreateBinaryReader(fs);//.xls
                   else
                       reader = ExcelReaderFactory.CreateOpenXmlReader(fs);//.xlsx

                   ReadExcelData(reader, true);
                 
               }
           }
       }

       public void GetExcelDataAlreadyCreated(string nameOfFile)
       {
           FileStream fs = new FileStream(nameOfFile, FileMode.Open, FileAccess.Read);
           fileName = nameOfFile;
           IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(fs);

           ReadExcelData(reader,false);
          
       }
    }
}
