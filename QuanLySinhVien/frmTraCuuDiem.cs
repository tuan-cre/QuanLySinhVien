using AZJ.QLSVDataSetTableAdapters;
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
    public partial class frmTraCuuDiem : Form
    {
        string MaNguoiDung;
        public frmTraCuuDiem(string MaNguoiDung)
        {
            InitializeComponent();
            this.MaNguoiDung = MaNguoiDung;
        }

        private void frmTraCuuDiem_Load(object sender, EventArgs e)
        {
            DataTable dt = this.hockyTableAdapter.GetData();
            DataRow dr = dt.NewRow();
            dr["MaHK"] = "All";
            dr["TenHK"] = "All";
            dr["NamHoc"] = "All";
            dt.Rows.InsertAt(dr, 0);
            cboFillterHocKy.DataSource = dt;
            cboFillterHocKy.DisplayMember = "TenHK";
            cboFillterHocKy.ValueMember = "MaHK";
            cboFillterHocKy.SelectedIndex = 0;

            this.diemTableAdapter.FillBy3B(this.qlsvDataSet.DIEM, MaNguoiDung);

            if (this.qlsvDataSet.DIEM.Rows.Count > 0)
                dgvTraCuuDiem.DataSource = this.qlsvDataSet.DIEM;
            else
                MessageBox.Show("Không có dữ liệu để hiển thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cboFillterHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFillterHocKy.SelectedValue.ToString() != "All")
            {
                this.diemTableAdapter.FillBy3BMaHK(this.qlsvDataSet.DIEM, MaNguoiDung, cboFillterHocKy.Text);
            }
            else
            {
                this.diemTableAdapter.FillBy3B(this.qlsvDataSet.DIEM, MaNguoiDung);
            }
        }
    }
}
