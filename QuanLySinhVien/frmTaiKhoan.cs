using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AZJ
{
    public partial class frmTaiKhoan : Form
    {
        public frmTaiKhoan()
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

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            cboFillterLoaiTaiKhoan.SelectedIndex = 0;

            this.taikhoanTableAdapter.Fill(this.qlsvDataSet.TAIKHOAN);
        }

        private void cboFillterLoaiTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFillterLoaiTaiKhoan.Text != "All")
            {
                this.taikhoanTableAdapter.FillByLoaiTaiKhoan(this.qlsvDataSet.TAIKHOAN, cboFillterLoaiTaiKhoan.Text);
            }
            else
            {
                this.taikhoanTableAdapter.Fill(this.qlsvDataSet.TAIKHOAN);
            }
        }

        private void txtFillterMaSo_TextChanged(object sender, EventArgs e)
        {
            if (cboFillterLoaiTaiKhoan.Text != "All")
            {
                if (txtFillterMaSo.Text == "")
                {
                    this.taikhoanTableAdapter.FillByLoaiTaiKhoan(this.qlsvDataSet.TAIKHOAN, cboFillterLoaiTaiKhoan.Text);
                }
                else
                {
                    this.taikhoanTableAdapter.FillByMaSoLoaiTaiKhoan(this.qlsvDataSet.TAIKHOAN, txtFillterMaSo.Text, cboFillterLoaiTaiKhoan.Text);
                }
            }
            else
            {
                if (txtFillterMaSo.Text == "")
                {
                    this.taikhoanTableAdapter.Fill(this.qlsvDataSet.TAIKHOAN);
                }
                else
                {
                    this.taikhoanTableAdapter.FillByMaSo(this.qlsvDataSet.TAIKHOAN, txtFillterMaSo.Text);
                }
            }

        }

        private void dgvTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.CurrentRow != null)
            {
                txtTenDangNhap.Text = dgvTaiKhoan.CurrentRow.Cells["TenDangNhap"].Value.ToString();
                txtMatKhau.Text = dgvTaiKhoan.CurrentRow.Cells["MatKhau"].Value.ToString();

                if (dgvTaiKhoan.CurrentRow.Cells["LoaiTaiKhoan"].Value.ToString() == "Sinh viên")
                {
                    cboLoaiTaiKhoan.SelectedIndex = 0;
                }
                else if (dgvTaiKhoan.CurrentRow.Cells["LoaiTaiKhoan"].Value.ToString() == "Giảng Viên")
                {
                    cboLoaiTaiKhoan.SelectedIndex = 1;
                }
                else
                {
                    cboLoaiTaiKhoan.SelectedIndex = 2;
                }
                txtMaSV.Text = dgvTaiKhoan.CurrentRow.Cells["MaSV"].Value.ToString().Trim();
                txtMaGV.Text = dgvTaiKhoan.CurrentRow.Cells["MaGV"].Value.ToString().Trim();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newRow = qlsvDataSet.TAIKHOAN.NewRow();
                newRow["TenDangNhap"] = txtTenDangNhap.Text;
                newRow["MatKhau"] = txtMatKhau.Text;
                newRow["LoaiTaiKhoan"] = cboLoaiTaiKhoan.Text;
                newRow["MaSV"] = txtMaSV.Text != "" ? txtMaSV.Text : null;
                newRow["MaGV"] = txtMaGV.Text != "" ? txtMaGV.Text : null;
                qlsvDataSet.TAIKHOAN.Rows.Add(newRow);
                dgvTaiKhoan.Refresh();
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.CurrentRow != null)
            {
                DataRowView rowView = dgvTaiKhoan.CurrentRow.DataBoundItem as DataRowView;
                DataRow rowToEdit = rowView.Row;
                rowToEdit["TenDangNhap"] = txtTenDangNhap.Text;
                rowToEdit["MatKhau"] = txtMatKhau.Text;
                rowToEdit["LoaiTaiKhoan"] = cboLoaiTaiKhoan.Text;
                rowToEdit["MaSV"] = txtMaSV.Text != "" ? txtMaSV.Text : null;
                rowToEdit["MaGV"] = txtMaGV.Text != "" ? txtMaGV.Text : null;
                dgvTaiKhoan.Refresh();
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tài khoản để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.CurrentRow != null)
            {
                DataRowView rowView = dgvTaiKhoan.CurrentRow.DataBoundItem as DataRowView;
                if (rowView != null)
                {
                    DataRow rowToDelete = rowView.Row;
                    rowToDelete.Delete();
                }
                dgvTaiKhoan.Refresh();
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tài khoản để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.taikhoanBindingSource.EndEdit();
                this.taikhoanTableAdapter.Update(this.qlsvDataSet.TAIKHOAN);
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
            this.qlsvDataSet.TAIKHOAN.RejectChanges();
            dgvTaiKhoan.Refresh();
            MessageBox.Show("Đã hủy các thay đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvTaiKhoan.ClearSelection();
            dgvTaiKhoan.Refresh();
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            cboLoaiTaiKhoan.SelectedIndex = 0;
            txtMaSV.Text = "";
            txtMaGV.Text = "";
        }
    }
}
