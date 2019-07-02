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
            //Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            //int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
            //int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
            //this.Location = new Point((screen.Width - w) / 2, (screen.Height - h) / 2);
            //this.Location = new Point(0, 0);
            //this.Size = new Size(w, h);
        }

        public Graphics(int p1, int p2, Point location)
        {
            InitializeComponent();
            this.Location = location;
            //this.Size = new Size(p1, p2);


            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);

            // no larger than screen size
            this.MaximumSize = new System.Drawing.Size(p1,p2);

            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
            //incarcareGrafic(0);

        private void incarcareGrafic(int index)
        {
            chart.ChartAreas[0].AxisX.Interval = 1;
            //chart.Height = 1000;

            if (index == 0)
            {
                for (int i = 0; i <= StructureExcel.MaxAge; i++)
                {
                    this.chart.Series["Functie"].Points.AddXY(CreateOutputFormat.output.X[i], CreateOutputFormat.output.SX[i]);
                }
                chart.ChartAreas[0].AxisY.Maximum = CreateOutputFormat.output.SX.Max();
            }
            else
                if (index == 1)
                {
                    for (int i = 0; i <= StructureExcel.MaxAge; i++)
                    {

                        this.chart.Series["Functie"].Points.AddXY(CreateOutputFormat.output.X[i], CreateOutputFormat.output.Dxx1[i]);
                    }
                    chart.ChartAreas[0].AxisY.Maximum = CreateOutputFormat.output.Dxx1.Max();
                }
                else
                    if (index == 2)
                    {
                        for (int i = 0; i <= StructureExcel.MaxAge; i++)
                        {

                            this.chart.Series["Functie"].Points.AddXY(CreateOutputFormat.output.X[i], CreateOutputFormat.output.Qx[i]);
                        }
                        chart.ChartAreas[0].AxisY.Maximum = FindTheGreatestLowerThan1(CreateOutputFormat.output.Qx);

                    }
                    else
                        if (index == 3)
                        {
                            for (int i = 0; i < StructureExcel.MaxAge; i++)
                            {

                                this.chart.Series["Functie"].Points.AddXY(CreateOutputFormat.output.X[i], CreateOutputFormat.output.Px[i]);
                            }
                            //chart.ChartAreas[0].AxisY.Minimum = FindTheLowestGReaterThan0(CreateOutputFormat.output.Px);
                            chart.ChartAreas[0].AxisY.Maximum = 1;
                        }
                        else
                            if (index == 4)
                            {
                                for (int i = 0; i < StructureExcel.MaxAge; i++)
                                {

                                    this.chart.Series["Functie"].Points.AddXY(CreateOutputFormat.output.X[i], CreateOutputFormat.output.Ex[i]);
                                }
                                chart.ChartAreas[0].AxisY.Maximum = 100;
                            }
            chart.ChartAreas[0].AxisX.Maximum = StructureExcel.MaxAge - 1;
            chart.ChartAreas[0].AxisX.Minimum = 0;

        }

        private double FindTheGreatestLowerThan1(List<double> list)
        {
            List<double> qxTemp = new List<double>();
            qxTemp.AddRange(list);
            qxTemp.Remove(1.0);
            return qxTemp.Max();
           
        }
        private double FindTheLowestGReaterThan0(List<double> list)
        {
            List<double> qxTemp = new List<double>();
            qxTemp.AddRange(list);
            qxTemp.Remove(0);
            return qxTemp.Min();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var series in chart.Series)
            {
                series.Points.Clear();
            }
            incarcareGrafic(comboBox1.SelectedIndex);
        }

        private void Graphics_Load(object sender, EventArgs e)
        {
        //    this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);

        //     no larger than screen size
        //    this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

        //    this.AutoSize = true;
        //    this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
    }
}
