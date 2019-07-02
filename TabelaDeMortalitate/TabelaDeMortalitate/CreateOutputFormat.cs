using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelaDeMortalitate
{
    public class CreateOutputFormat
    {
      public static OutputFormat output = new OutputFormat();
        

      public void createOutput()
      {
          output.RemoveItemsFromOutputLists();
          for (int i = 0; i <= StructureExcel.MaxAge; i++)
          {
              output.X.Add(i);

              if (i == 0)
              {
                  if (StructureExcel.NewBorns[3] == 0)
                  {
                      output.Qx.Add((StructureExcel.MortalitysFirstYear[0] +
                          StructureExcel.MortalitysSecondYear[0] + StructureExcel.MortalitysThirdYear[0]) * 1.0 /
                          (StructureExcel.NewBorns[0] + StructureExcel.NewBorns[1] + StructureExcel.NewBorns[2]));
                  }
                  else
                  {
                      output.Qx.Add(1 / 3.0 *
                          (StructureExcel.MortalitysFirstYear[0] * 1.0 / (1 / 5.0 * StructureExcel.NewBorns[0] + 4 / 5.0 * StructureExcel.NewBorns[1]) +
                         StructureExcel.MortalitysSecondYear[0] * 1.0 / (1 / 5.0 * StructureExcel.NewBorns[1] + 4 / 5.0 * StructureExcel.NewBorns[2]) +
                         StructureExcel.MortalitysThirdYear[0] * 1.0 / (1 / 5.0 * StructureExcel.NewBorns[2] + 4 / 5.0 * StructureExcel.NewBorns[3])));

                  }
                  output.Mx.Add(0);
              }
              else
              {
                  output.Mx.Add(1 / 3.0 *
                      (StructureExcel.MortalitysFirstYear[i] +
                      StructureExcel.MortalitysSecondYear[i] +
                      StructureExcel.MortalitysThirdYear[i]) /
                      StructureExcel.PopulationAverage[i]
                      );
                  output.Qx.Add((2 * output.Mx[i]) / (2 + output.Mx[i]));
              }
          }


          //int point = DetermineThePointToMakeAdjustments();

          //int firstNumber;
          //int step;
          //DetermineFirstNumberAndStepForAdjustments(point, out firstNumber, out step);

          List<double> qxAjustat = makeAdjustments();


          for (int i = 70; i < StructureExcel.MaxAge; i++)
          {
              output.Qx[i] = qxAjustat[i - 70];
          }
          output.Qx[100] = 1;

          for (int i = 0; i <= StructureExcel.MaxAge; i++)
          {
              output.Px.Add(1 - output.Qx[i]);
              if (i == 0)
              {
                  output.SX.Add(100000);
                  output.Dxx1.Add((100000 * output.Qx[0]));

              }
              else
              {
                  output.SX.Add(output.SX[i - 1] - output.Dxx1[i - 1]);
                  output.Dxx1.Add(output.SX[i] * output.Qx[i]);
              }
          }

          for (int i = 0; i < StructureExcel.MaxAge; i++)
          {
              if (i == 0)
                  output.LX.Add(output.SX[i] * 0.2 + output.SX[i + 1] * 0.8);
              else
                  output.LX.Add((output.SX[i] + output.SX[i + 1]) / 2.0);
          }


          output.TX.Add(output.LX[StructureExcel.MaxAge - 1]);
          for (int i = StructureExcel.MaxAge - 1; i >= 0; i--)
          {
              output.TX.Add(output.LX[i] + output.TX[output.TX.Count - 1]);
          }
          output.TX.Reverse();

          for (int i = 0; i <= StructureExcel.MaxAge; i++)
          {
              output.Ex.Add(output.TX[i] / output.SX[i]);
          }
      }


      public List<double> makeAdjustments(int n1 = 75, int n2 = 85, int n3 = 95, int tMin = -5, int tMax = 24)
      {                                                                          
          double y1 = Math.Pow(output.Qx[n1-1] * output.Qx[n1] * output.Qx[n1+1], 1.00000000000 / 3);
          double y2 = Math.Pow(output.Qx[n2-1] * output.Qx[n2] * output.Qx[n2+1], 1.00000000000 / 3);
          double y3 = Math.Pow(output.Qx[n3-1] * output.Qx[n3] * output.Qx[n3+1], 1.00000000000 / 3);

          double a = ((2 * y1 * y2 * y3) - (y2 * y2) * (y1 + y3)) / ((y1 * y3) - (y2 * y2));
          double b = (a - y1) / y1;
          double c = 1.0 / 10 * 2.3026 * Math.Log10((y2 * (a - y1)) / (y1 * (a - y2)));

          List<double> qxAjustat = new List<double>();
          for (int j = tMin; j <= tMax; j++)
          {
              double y = a / (1 + b * Math.Pow(2.71, -c * j));
              qxAjustat.Add(y);
          }
          return qxAjustat;
      }


      public void DetermineFirstNumberAndStepForAdjustments( int point, out int firstNumber, out int step)
      {
          firstNumber = 75;
          step = 10;
         if(point >= 85 && point <= 89)
         {
             firstNumber = 90;
             step = 4;
         }
         else
         {
             bool ok = true;
             for(int i = 1; i <= 5 && ok ; i++)
             {
                 if((point + i ) % 5 == 0)
                 {
                     ok = false;
                     
                     if ((point + i) % 2 == 1)
                     {
                         firstNumber = point + i;
                         step = (95 - (point + i)) / 2;
                     }
                     else
                     {
                         firstNumber = point + i;
                         step = (90 - (point + i)) / 2;
                     }

                 }
             }
         }
         
      }
      public int DetermineThePointToMakeAdjustments()
      {
          for (int i = 55; i < 90; i++)
          {
              bool condition1 = output.Qx[i+1] < output.Qx[i] && output.Qx[i + 2] > output.Qx[i + 1] && output.Qx[i + 3] < output.Qx[i + 2] && output.Qx[i + 4] > output.Qx[i + 3];
              bool condition2 = output.Qx[i+1] < output.Qx[i] && output.Qx[i + 2] < output.Qx[i + 1] && output.Qx[i + 3] > output.Qx[i + 2] && output.Qx[i + 4] < output.Qx[i + 3];
              bool condition3 = output.Qx[i+1] < output.Qx[i] && output.Qx[i + 2] < output.Qx[i + 1] && output.Qx[i + 3] < output.Qx[i + 2] && output.Qx[i + 4] > output.Qx[i + 3];
              bool condition4 = output.Qx[i+1] < output.Qx[i] && output.Qx[i + 2] < output.Qx[i + 1] && output.Qx[i + 3] < output.Qx[i + 2] && output.Qx[i + 4] > output.Qx[i + 3];
              if (condition1 || condition2 || condition3 || condition4)
                  return i;
          }
          return 70;
      }

      //  public int DetermineTheStepToMakeAdjustments()
      //{
      //    int[] diffs = new int[100];
      //    int indexToReturn = 70;
      //    for(int i = 55; i <99; i++)
      //    {
      //        if (output.Qx[i + 1] < output.Qx[i])
      //        {   
      //            diffs[i + 1] = diffs[i] + 1;
      //        }
      //        else
      //        {
      //            diffs[i + 1] = diffs[i];
      //        }
      //    }
      //    bool ok = true;
      //    for(int i = 55; i < 96 && ok ; i++)
      //    {
      //      if (diffs[i + 4] - diffs[i] >= 2)
      //       {
      //          ok = false;
      //          indexToReturn = i+1;
      //        }
      //    }
      //    return indexToReturn;
      //}
           
     }

        
}

