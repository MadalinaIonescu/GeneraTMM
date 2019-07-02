using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using System.IO;
using System.Windows.Forms;

namespace TabelaDeMortalitate
{
   public class WriteExcel
    {
        public static String fileName;

        public String FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        public bool CheckNoDataAndWriteValue(int a)
        {
            bool noData = false;
            if (a < 0)
            {
                noData = true;
            }
            return noData;

        }

       public object WriteValue(int a)
        {
            if (a < 0)
                return ":";
            else
                return a;
        }
       
       public void WriteToExcel(List<PopulationEntry> populations, List<MortalityEntry> mortalitys, NewBornEntry newBorns)
       {
           using(ExcelPackage excel = new ExcelPackage())
           {
               excel.Workbook.Worksheets.Add("Input");


               var headerRow = new List<string[]>()
               {
                   new string []
                   {
                    "", "Populatie An 2", "Populatie An 3",
                    "Mortalitate An 1", "Mortalitate An 2",
                   "Mortalitate An 3", "Nou-nascuti An 0",
                   "Nou-nascuti An 1", "Nou-nascuti An 2",
                   "Nou-nascuti an 3"
                   }
               };

               string headerRange = "A1:" + Char.ConvertFromUtf32(headerRow[0].Length + 64) + "1";

               var worksheet = excel.Workbook.Worksheets["Input"];

               worksheet.Cells[headerRange].LoadFromArrays(headerRow.ToList());
               worksheet.Cells[headerRange].Style.Font.Bold = true;
               worksheet.Cells[headerRange].Style.Font.Size = 12;
               worksheet.Cells[headerRange].Style.Font.Color.SetColor(System.Drawing.Color.Blue);

               for (int i = 0; i <= populations.Count - 1; i++)
               {
                   string cellsRange;
                   var row = new List<object[]>();
                   if (i == 0)
                   {

                       row = new List<object[]>()
                       {
                           new object []
                           {
                               "Sub 1 an" , WriteValue(populations[i].PopulationValueYear2) ,WriteValue(populations[i].PopulationValueYear3),
                               WriteValue(mortalitys[i].MortalityValueYear1), WriteValue(mortalitys[i].MortalityValueYear2), WriteValue(mortalitys[i].MortalityValueYear3),
                               WriteValue(newBorns.NewBornsYear0), WriteValue(newBorns.NewBornsYear1), WriteValue(newBorns.NewBornsYear2), WriteValue(newBorns.NewBornsYear3)
                           }
                       };
                   }
                   else
                   {
                       row = new List<object[]>()
                       {
                           new object []
                           {
                               populations[i].IntAge+" ani" , WriteValue(populations[i].PopulationValueYear2), WriteValue(populations[i].PopulationValueYear3),
                               WriteValue(mortalitys[i].MortalityValueYear1), WriteValue(mortalitys[i].MortalityValueYear2), WriteValue(mortalitys[i].MortalityValueYear3)
                              
                           }
                       };
                   }

                   cellsRange = "A" + (i + 2).ToString()+":" + Char.ConvertFromUtf32(row[0].Length + 64) + (i + 2).ToString() + ":";
                   worksheet.Cells[cellsRange].LoadFromArrays(row.ToList());
                   worksheet.Cells[cellsRange].Style.Font.Bold = false;
                   worksheet.Cells[cellsRange].Style.Font.Size = 10;
                   worksheet.Cells[cellsRange].Style.Font.Color.SetColor(System.Drawing.Color.Black);
               }

                   try
                   {
                       if (File.Exists(fileName + ".xlsx"))
                           File.Delete(fileName + ".xlsx");

                       FileInfo excelFile = new FileInfo(fileName + ".xlsx");
                       excel.SaveAs(excelFile);
                   }
                   catch (Exception ex)
                   {
                   }
           }
           
       }
    }
}
