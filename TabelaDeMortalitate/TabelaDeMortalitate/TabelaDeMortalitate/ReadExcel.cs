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
       public void getExcelData()
       {
           
           using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook 97-2003|*.xls| Excel Workbook|*.xlsx" })
           {
               if (ofd.ShowDialog() == DialogResult.OK)
               {
                   FileStream fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read);
                   fileName = ofd.SafeFileName;
                   IExcelDataReader reader;
                   if (ofd.FilterIndex == 1)
                       reader = ExcelReaderFactory.CreateBinaryReader(fs);
                   else
                       reader = ExcelReaderFactory.CreateOpenXmlReader(fs);

                   // reader.IsFirstRowAsColumnNames = true;
                   /*   DataSet result  = reader.AsDataSet(new ExcelDataSetConfiguration()
                      {
                          ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                          {
                              UseHeaderRow = true
                          }
                      });*/
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

                       while (reader.Read() )
                       {
                           ok++;
                           if (ok == 0 )
                           {

                           }
                           
                            
                           else
                           {
                   
                               
                           
                               Console.Write(reader.GetDouble(1)+" ");
                               StructureExcel.PopulationYear2.Add((int)reader.GetDouble(1));
                               StructureExcel.PopulationYear3.Add((int)reader.GetDouble(2));
                               StructureExcel.MortalitysFirstYear.Add((int)reader.GetDouble(3));
                               StructureExcel.MortalitysSecondYear.Add((int)reader.GetDouble(4));
                               StructureExcel.MortalitysThirdYear.Add((int)reader.GetDouble(5));

                               Console.Write(reader.GetDouble(2)+" ");
                               Console.Write(reader.GetDouble(3)+" ");
                               Console.Write(reader.GetDouble(4)+" ");
                               Console.Write(reader.GetDouble(5)+" ");
                               Console.WriteLine();

                               if (ok == 1 && reader.FieldCount == 10)
                               {
                                   StructureExcel.NewBorns[0] = (int)reader.GetDouble(6);
                                   StructureExcel.NewBorns[1] = (int)reader.GetDouble(7);
                                   StructureExcel.NewBorns[2] = (int)reader.GetDouble(8);
                                   StructureExcel.NewBorns[3] = (int)reader.GetDouble(9);


                                   Console.WriteLine("New borns10 ");
                                   Console.WriteLine(StructureExcel.NewBorns[0]);
                                   Console.WriteLine(StructureExcel.NewBorns[1]);
                                   Console.WriteLine(StructureExcel.NewBorns[2]);
                                   Console.WriteLine(StructureExcel.NewBorns[3]);

                               }
                               else
                                   if (ok == 1 && reader.FieldCount == 9)
                                   {
                                       StructureExcel.NewBorns[0] = (int)reader.GetDouble(6);
                                       StructureExcel.NewBorns[1] = (int)reader.GetDouble(7);
                                       StructureExcel.NewBorns[2] = (int)reader.GetDouble(8);
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
                           }
                           
                       }
                       Console.WriteLine(ok);
                       StructureExcel.setPopulationAverage();
                       StructureExcel.MaxAge = ok - 1;
                       status = true;
                       
                      
                   }
                   catch (Exception ex)
                   {
                       MessageBox.Show("Fisierul nu are formatul corect", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       status = false;
                   }

                   //6. Free resources (IExcelDataReader is IDisposable)
                   reader.Close();
               }
           }
       }
    }
}
