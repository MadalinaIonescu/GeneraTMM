using Microsoft.Reporting.WinForms;
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
    public partial class Tabela : Form
    {
        public Tabela()
        {
            InitializeComponent();
        }

        private void Tabela_Load(object sender, EventArgs e)
        {
            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);
            for (int i = 0; i < StructureExcel.MaxAge;i++ )
            {
                Date.Tables[0].Rows.Add(CreateOutputFormat.output.X[i], Math.Round(CreateOutputFormat.output.SX[i], MidpointRounding.AwayFromZero),
                  Math.Round(CreateOutputFormat.output.Dxx1[i], MidpointRounding.AwayFromZero), CreateOutputFormat.output.Qx[i],
                    CreateOutputFormat.output.Px[i], Math.Round(CreateOutputFormat.output.LX[i], MidpointRounding.AwayFromZero),
                    Math.Round(CreateOutputFormat.output.TX[i], MidpointRounding.AwayFromZero), CreateOutputFormat.output.Ex[i]);
            }
            Date.Tables[0].Rows.Add(CreateOutputFormat.output.X[StructureExcel.MaxAge], Math.Round(CreateOutputFormat.output.SX[StructureExcel.MaxAge], MidpointRounding.AwayFromZero),
                   Math.Round(CreateOutputFormat.output.Dxx1[StructureExcel.MaxAge], MidpointRounding.AwayFromZero), CreateOutputFormat.output.Qx[StructureExcel.MaxAge],
                    CreateOutputFormat.output.Px[StructureExcel.MaxAge], null,
                    Math.Round(CreateOutputFormat.output.TX[StructureExcel.MaxAge], MidpointRounding.AwayFromZero), CreateOutputFormat.output.Ex[StructureExcel.MaxAge]);

            string[] name=ReadExcel.fileName.Split('.');
            ReportParameter rp = new ReportParameter("content", name[0]);
            this.reportViewer.LocalReport.SetParameters(new ReportParameter[] { rp });
            this.reportViewer.RefreshReport();
          
            
            
            
        }
    }
}
