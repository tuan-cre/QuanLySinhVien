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
    public partial class frmTraCuuKetQua : Form
    {
        string MaNguoiDung;
        private bool isLoading = true;

        public frmTraCuuKetQua(string maNguoiDung)
        {
            InitializeComponent();
            MaNguoiDung = maNguoiDung;
        }

        private void cboFillterHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading)
                return;

            if (cboFillterHocKy.SelectedValue.ToString() == "All")
            {
                this.ketquaTableAdapter.FillBy2B(this.qlsvDataSet.KETQUA, MaNguoiDung);
                if (this.qlsvDataSet.KETQUA.Rows.Count > 0)
                {
                    // Tạo một bản sao của dòng đầu tiên
                    DataTable firstRowTable = this.qlsvDataSet.KETQUA.Clone(); // Sao chép cấu trúc bảng
                    firstRowTable.ImportRow(this.qlsvDataSet.KETQUA.Rows[0]);  // Thêm dòng đầu tiên

                    // Gán DataSource cho DataGridView
                    dgvTraCuuKQ.DataSource = firstRowTable;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                this.ketquaTableAdapter.FillBy2BTenHK(this.qlsvDataSet.KETQUA, MaNguoiDung, cboFillterHocKy.Text);
                // Kiểm tra nếu có dữ liệu
                if (this.qlsvDataSet.KETQUA.Rows.Count > 0)
                {
                    // Tạo một bản sao của dòng đầu tiên
                    DataTable firstRowTable = this.qlsvDataSet.KETQUA.Clone(); // Sao chép cấu trúc bảng
                    firstRowTable.ImportRow(this.qlsvDataSet.KETQUA.Rows[0]);  // Thêm dòng đầu tiên

                    // Gán DataSource cho DataGridView
                    dgvTraCuuKQ.DataSource = firstRowTable;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void frmTraCuuKetQua_Load(object sender, EventArgs e)
        {
            isLoading = true;

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

            this.ketquaTableAdapter.FillBy2B(this.qlsvDataSet.KETQUA, MaNguoiDung);

            // Kiểm tra nếu có dữ liệu
            if (this.qlsvDataSet.KETQUA.Rows.Count > 0)
            {
                // Tạo một bản sao của dòng đầu tiên
                DataTable firstRowTable = this.qlsvDataSet.KETQUA.Clone(); // Sao chép cấu trúc bảng
                firstRowTable.ImportRow(this.qlsvDataSet.KETQUA.Rows[0]);  // Thêm dòng đầu tiên

                // Gán DataSource cho DataGridView
                dgvTraCuuKQ.DataSource = firstRowTable;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            isLoading = false;
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
    }
}