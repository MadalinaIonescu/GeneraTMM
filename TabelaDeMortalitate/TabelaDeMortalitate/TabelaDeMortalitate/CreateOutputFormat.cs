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
            for(int i=0;i<=StructureExcel.MaxAge;i++)
            {
                output.X.Add(i);

                if (i == 0)
                {
                    if (StructureExcel.NewBorns[3] == 0)
                    {
                        output.Qx.Add((StructureExcel.MortalitysFirstYear[0]+
                            StructureExcel.MortalitysSecondYear[0]+StructureExcel.MortalitysThirdYear[0])*1.0/
                            (StructureExcel.NewBorns[0]+StructureExcel.NewBorns[1]+StructureExcel.NewBorns[2]));
                    }
                    else
                    {
                        output.Qx.Add(1 / 3.0 *
                            (StructureExcel.MortalitysFirstYear[0] * 1.0 / (1 / 5.0 * StructureExcel.NewBorns[0] + 4 / 5.0 * StructureExcel.NewBorns[1]) +
                           StructureExcel.MortalitysSecondYear[0] * 1.0 / (1 / 5.0 * StructureExcel.NewBorns[1] + 4 / 5.0 * StructureExcel.NewBorns[2]) +
                           StructureExcel.MortalitysFirstYear[0] * 1.0 / (1 / 5.0 * StructureExcel.NewBorns[2] + 4 / 5.0 * StructureExcel.NewBorns[3]) ));

                    }
                    output.Mx.Add(0);
                }
                else
                {
                    output.Mx.Add(1/3.0*
                        (StructureExcel.MortalitysFirstYear[i]+
                        StructureExcel.MortalitysSecondYear[i]+
                        StructureExcel.MortalitysThirdYear[i])/
                        StructureExcel.PopulationAverage[i]
                        );

                    output.Qx.Add((2 * output.Mx[i] / (2 + output.Mx[i])));
                }

                }


            for (int i = 0; i <= StructureExcel.MaxAge; i++)
            {
                output.Px.Add(1 - output.Qx[i]);
                if (i == 0)
                {
                    output.SX.Add(100000);
                    output.Dxx1.Add((100000*output.Qx[0]));

                }
                else
                {
                    output.SX.Add(output.SX[i - 1] - output.Dxx1[i - 1]);
                    output.Dxx1.Add(output.SX[i] * output.Qx[i]);
                }

              
                
            }

            for(int i=0;i<StructureExcel.MaxAge;i++)
            {
                output.LX.Add(output.SX[i] + output.SX[i + 1] / 2.0);
            }

            
            output.TX.Add(output.LX[StructureExcel.MaxAge - 1]);
            for(int i=StructureExcel.MaxAge-1;i>=0;i--)
            {
                output.TX.Add(output.LX[i]+output.TX[output.TX.Count-1]);
            }
            output.TX.Reverse();

            for(int i=0;i<=StructureExcel.MaxAge;i++)
            {
                output.Ex.Add(output.TX[i] / output.SX[i]);
            }
            }
           
        }

        
}

