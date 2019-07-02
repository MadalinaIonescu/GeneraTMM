using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabelaDeMortalitate
{
    public partial class Graphics : Form
    {
        public Graphics()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            //incarcareGrafic(0);
        }

        private void incarcareGrafic(int index)
        {
            chart.ChartAreas[0].AxisX.Interval = 1;

            if (index == 0)
                for (int i = 0; i <= StructureExcel.MaxAge; i++ )
                {
               
                    this.chart.Series["Functie"].Points.AddXY(CreateOutputFormat.output.X[i],CreateOutputFormat.output.SX[i]);
                
                }
            else
                if(index ==1)
                {
                    for (int i = 0; i <= StructureExcel.MaxAge; i++)
                    {

                        this.chart.Series["Functie"].Points.AddXY(CreateOutputFormat.output.X[i], CreateOutputFormat.output.Dxx1[i]);

                    }
                }
                else
                    if (index == 2)
                    {
                        for (int i = 0; i <= StructureExcel.MaxAge; i++)
                        {

                            this.chart.Series["Functie"].Points.AddXY(CreateOutputFormat.output.X[i], CreateOutputFormat.output.Qx[i]);

                        }
                    }
                    else
                        if (index == 3)
                        {
                            for (int i = 0; i <= StructureExcel.MaxAge; i++)
                            {

                                this.chart.Series["Functie"].Points.AddXY(CreateOutputFormat.output.X[i], CreateOutputFormat.output.Px[i]);

                            }
                        }
                        else
                            if (index == 4)
                            {
                                for (int i = 0; i <= StructureExcel.MaxAge; i++)
                                {

                                    this.chart.Series["Functie"].Points.AddXY(CreateOutputFormat.output.X[i], CreateOutputFormat.output.Ex[i]);

                                }
                            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var series in chart.Series)
            {
                series.Points.Clear();
            }
            incarcareGrafic(comboBox1.SelectedIndex);
        }
    }
}
