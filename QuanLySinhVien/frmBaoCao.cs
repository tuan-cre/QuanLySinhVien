using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AZJ
{
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                ColorTranslator.FromHtml("#f4baeb"),
                ColorTranslator.FromHtml("#6bd3db"),
                LinearGradientMode.ForwardDiagonal))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            ReportDocument rptBaoCao = new ReportDocument();
            rptBaoCao.Load(@"D:\QuanLySinhVien\QuanLySinhVien\BaoCaoSinhVien.rpt");

            DataTable sinhvienData = sinhvienTableAdapter.GetData();
            rptBaoCao.SetDataSource((DataTable)sinhvienData);
            crystalReportViewer.ReportSource = rptBaoCao;
            crystalReportViewer.Zoom(75);
        }
    }
}
