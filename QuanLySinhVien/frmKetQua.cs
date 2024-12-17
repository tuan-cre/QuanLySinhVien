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
    public partial class frmKetQua : Form
    {
        public frmKetQua()
        {
            InitializeComponent();
        }

        private void frmKetQua_Load(object sender, EventArgs e)
        {
            DataTable dt = this.hockiTableAdapter.GetData();
            DataRow dr = dt.NewRow();
            dr["MaHK"] = "All";
            dr["TenHK"] = "All";
            dr["NamHoc"] = "All";
            dt.Rows.InsertAt(dr, 0);
            cboFillterMaHK.DataSource = dt;
            cboFillterMaHK.DisplayMember = "TenHK";
            cboFillterMaHK.ValueMember = "MaHK";
            cboFillterMaHK.SelectedIndex = 0;

            this.ketquaTableAdapter.Fill(this.qlsvDataSet.KETQUA);

        }

        private void cboFillterHocKi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFillterMaHK.SelectedValue.ToString() != "All")
            {
                this.ketquaTableAdapter.FillByMaHK(this.qlsvDataSet.KETQUA, cboFillterMaHK.SelectedValue.ToString());
            }
            else
            {
                this.ketquaTableAdapter.Fill(this.qlsvDataSet.KETQUA);
            }
        }

        private void txtFillterMaSV_TextChanged(object sender, EventArgs e)
        {
            if (cboFillterMaHK.SelectedValue.ToString() != "All")
            {
                this.ketquaTableAdapter.FillByMaSVMaHK(this.qlsvDataSet.KETQUA, txtFillterMaSV.Text, cboFillterMaHK.SelectedValue.ToString());
            }
            else
            {
                this.ketquaTableAdapter.FillByMaSV(this.qlsvDataSet.KETQUA, txtFillterMaSV.Text);
            }
        }

        private void dgvLop_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKetqua.CurrentRow != null)
            {
                txtMaKQ.Text = dgvKetqua.CurrentRow.Cells["MaKQ"].Value.ToString().Trim();
                txtMaSV.Text = dgvKetqua.CurrentRow.Cells["MaSV"].Value.ToString().Trim();
                txtMaHK.Text = dgvKetqua.CurrentRow.Cells["MaHK"].Value.ToString().Trim();
                txtSoTinChiDat.Text = dgvKetqua.CurrentRow.Cells["SoTinChiDat"].Value.ToString();
                txtDiemTB.Text = dgvKetqua.CurrentRow.Cells["DiemTB"].Value.ToString();
                txtXepLoai.Text = dgvKetqua.CurrentRow.Cells["XepLoai"].Value.ToString();
            }    
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newRow = qlsvDataSet.KETQUA.NewRow();
                newRow["MaKQ"] = 0;
                newRow["MaSV"] = txtMaSV.Text;
                newRow["MaHK"] = txtMaHK.Text;

                var soTinChiDat = diemTableAdapter.TSTC(txtMaSV.Text, txtMaHK.Text);
                newRow["SoTinChiDat"] = soTinChiDat != null ? soTinChiDat : DBNull.Value;

                var diemTB = diemTableAdapter.DiemTB(txtMaSV.Text, txtMaHK.Text);
                newRow["DiemTB"] = diemTB != null ? diemTB : DBNull.Value;

                double dtb = Convert.ToDouble(diemTB);

                //Xeploai: yeu < 5, trung binh 5-6.5, kha 6.5-8, gioi 8-9, xuat sac 9-10
                if (dtb < 5)
                {
                    newRow["XepLoai"] = "Yếu";
                }
                else if (dtb >= 5 && dtb < 6.5)
                {
                    newRow["XepLoai"] = "Trung Bình";
                }
                else if (dtb >= 6.5 && dtb < 8)
                {
                    newRow["XepLoai"] = "Khá";
                }
                else if (dtb >= 8 && dtb < 9)
                {
                    newRow["XepLoai"] = "Giỏi";
                }
                else if (dtb >= 9 && dtb <= 10)
                {
                    newRow["XepLoai"] = "Xuất Sắc";
                }

                int stcd = Convert.ToInt32(soTinChiDat);

                newRow["TrangThai"] = stcd < 15 ? "Đang Học" : "Đã Hoàn Thành";
                //newRow["XepLoai"] = txtXepLoai.Text;
                qlsvDataSet.KETQUA.Rows.Add(newRow);
                dgvKetqua.Refresh();
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKetqua.CurrentRow != null)
            {
                DataRowView rowView = dgvKetqua.CurrentRow.DataBoundItem as DataRowView;
                DataRow rowToEdit = rowView.Row;
                rowToEdit["MaSV"] = txtMaSV.Text;
                rowToEdit["MaHK"] = txtMaHK.Text;

                var soTinChiDat = diemTableAdapter.TSTC(txtMaSV.Text, txtMaHK.Text);
                rowToEdit["SoTinChiDat"] = soTinChiDat != null ? soTinChiDat : 0;

                var diemTB = diemTableAdapter.DiemTB(txtMaSV.Text, txtMaHK.Text);
                rowToEdit["DiemTB"] = diemTB != null ? diemTB : 0;

                double dtb = Convert.ToDouble(rowToEdit["DiemTB"]);

                if (dtb < 5)
                {
                    rowToEdit["XepLoai"] = "Yếu";
                }
                else if (dtb >= 5 && dtb < 6.5)
                {
                    rowToEdit["XepLoai"] = "Trung Bình";
                }
                else if (dtb >= 6.5 && dtb < 8)
                {
                    rowToEdit["XepLoai"] = "Khá";
                }
                else if (dtb >= 8 && dtb < 9)
                {
                    rowToEdit["XepLoai"] = "Giỏi";
                }
                else if (dtb >= 9 && dtb <= 10)
                {
                    rowToEdit["XepLoai"] = "Xuất Sắc";
                }

                int stcd = Convert.ToInt32(soTinChiDat);

                rowToEdit["TrangThai"] = stcd < 15 ? "Đang Học" : "Đã Hoàn Thành";

                dgvKetqua.Refresh();
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn kết quả để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKetqua.CurrentRow != null)
            {
                DataRowView rowView = dgvKetqua.CurrentRow.DataBoundItem as DataRowView;
                if (rowView != null)
                {
                    DataRow rowToDelete = rowView.Row;
                    rowToDelete.Delete();
                }
                dgvKetqua.Refresh();
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn kết quả để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.ketquaBindingSource.EndEdit();
                this.ketquaTableAdapter.Update(this.qlsvDataSet.KETQUA);
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.qlsvDataSet.KETQUA.RejectChanges();
            dgvKetqua.Refresh();
            MessageBox.Show("Đã hủy các thay đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvKetqua.ClearSelection();
            dgvKetqua.Refresh();
            txtMaKQ.Text = "";
            txtMaSV.Text = "";
            txtMaHK.Text = "";
            txtSoTinChiDat.Text = "";
            txtDiemTB.Text = "";
            txtXepLoai.Text = "";
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
