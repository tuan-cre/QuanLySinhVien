using AZJ.QLSVDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AZJ
{
    public partial class frmSinhVien : Form
    {
        string MaNguoiDung;
        public frmSinhVien()
        {
            InitializeComponent();
        }

        public frmSinhVien(string MaNguoiDung)
        {
            InitializeComponent();
            this.MaNguoiDung = MaNguoiDung;
            this.temp.Text = MaNguoiDung;
        }

        private void SinhVienForm_Load(object sender, EventArgs e)
        {
            if (MaNguoiDung != null)
            {
                DataTable dt2 = this.khoaTableAdapter.GetDataByMaGV(MaNguoiDung);
                cboFillterKhoa.DataSource = dt2;
                cboFillterKhoa.DisplayMember = "TenKhoa";
                cboFillterKhoa.ValueMember = "MaKhoa";
                cboFillterKhoa.SelectedIndex = 0;
                this.sinhvienTableAdapter.FillByMaKhoa(this.qlsvDataSet.SINHVIEN, cboFillterKhoa.SelectedValue.ToString());

                DataTable dt3 = this.lopTableAdapter.GetDataByMaGV(MaNguoiDung);
                cboFillterLop.DataSource = dt3;
                cboFillterLop.DisplayMember = "TenLop";
                cboFillterLop.ValueMember = "MaLop";
                cboFillterLop.SelectedIndex = 0;
                this.sinhvienTableAdapter.FillByMaLop(this.qlsvDataSet.SINHVIEN, cboFillterLop.SelectedValue.ToString());

                txtMaKhoa.Enabled = false;
                txtMaLop.Enabled = false;
            }
            else
            {
                DataTable dt = this.khoaTableAdapter.GetData();
                DataRow dr = dt.NewRow();
                dr["MaKhoa"] = "All";
                dr["TenKhoa"] = "All";
                dt.Rows.InsertAt(dr, 0);
                cboFillterKhoa.DataSource = dt;
                cboFillterKhoa.DisplayMember = "TenKhoa";
                cboFillterKhoa.ValueMember = "MaKhoa";
                cboFillterKhoa.SelectedIndex = 0;
                this.sinhvienTableAdapter.Fill(this.qlsvDataSet.SINHVIEN);
            } 
        }

        private void cboFillterKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFillterKhoa.SelectedValue.ToString() != "All")
            {
                this.sinhvienTableAdapter.FillByMaKhoa(this.qlsvDataSet.SINHVIEN, cboFillterKhoa.SelectedValue.ToString());
                this.lopTableAdapter.FillByMaKhoa(this.qlsvDataSet.LOP, cboFillterKhoa.SelectedValue.ToString());
                DataTable dt = new LOPTableAdapter().GetDataByMaKhoa(cboFillterKhoa.SelectedValue.ToString());
                DataRow row = dt.NewRow();
                row["MaLop"] = "All";
                row["TenLop"] = "All";
                dt.Rows.InsertAt(row, 0);
                cboFillterLop.DataSource = dt;
                cboFillterLop.DisplayMember = "TenLop";
                cboFillterLop.ValueMember = "MaLop";
            }
            else
            {
                this.sinhvienTableAdapter.Fill(this.qlsvDataSet.SINHVIEN);
            }
        }

        private void cboFillterLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFillterLop.SelectedValue.ToString() != "All")
            {
                this.sinhvienTableAdapter.FillByMaLop(this.qlsvDataSet.SINHVIEN, cboFillterLop.SelectedValue.ToString());
            }
            else if (cboFillterKhoa.SelectedValue.ToString() != "All")
            {
                this.sinhvienTableAdapter.FillByMaKhoa(this.qlsvDataSet.SINHVIEN, cboFillterKhoa.SelectedValue.ToString());
            }
            else
            {
                this.sinhvienTableAdapter.Fill(this.qlsvDataSet.SINHVIEN);
            }
        }

        private void txtFillterMaSV_TextChanged(object sender, EventArgs e)
        {
            if (cboFillterKhoa.SelectedValue.ToString() != "All")
            {
                if (cboFillterLop.SelectedValue.ToString() != "All")
                {
                    this.sinhvienTableAdapter.FillByMaSVMaLopMaKhoa(this.qlsvDataSet.SINHVIEN, txtFillterMaSV.Text.Trim() + '%', cboFillterLop.SelectedValue.ToString(), cboFillterKhoa.SelectedValue.ToString());
                }
                else
                {
                    this.sinhvienTableAdapter.FillByMaSVMaKhoa(this.qlsvDataSet.SINHVIEN, txtFillterMaSV.Text.Trim() + '%', cboFillterKhoa.SelectedValue.ToString());
                }
            }
            else
            {
                this.sinhvienTableAdapter.FillByMaSV(this.qlsvDataSet.SINHVIEN, txtFillterMaSV.Text.Trim() + '%');
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo một dòng mới trong DataTable
                DataRow newRow = qlsvDataSet.SINHVIEN.NewRow();
                newRow["MaSV"] = txtMaSV.Text;
                newRow["HoTen"] = txtHoTen.Text;
                //newRow["NgaySinh"] = DateTime.Parse(txtNgaySinh.Text);
                newRow["NgaySinh"] = DateTime.Parse(dtpNgaySinh.Text);
                //newRow["GioiTinh"] = txtGioiTinh.Text;
                newRow["GioiTinh"] = cboGioiTinh.SelectedItem.ToString();
                newRow["DiaChi"] = txtDiaChi.Text;
                newRow["Email"] = txtEmail.Text;
                newRow["SDT"] = txtSDT.Text;
                //newRow["TrangThai"] = txtTrangThai.Text;
                newRow["TrangThai"] = cboTrangThai.SelectedItem.ToString();

                if (MaNguoiDung != null)
                {
                    newRow["MaKhoa"] = cboFillterKhoa.SelectedValue.ToString();
                    newRow["MaLop"] = cboFillterLop.SelectedValue.ToString();
                }
                else
                {
                    newRow["MaKhoa"] = txtMaKhoa.Text;
                    newRow["MaLop"] = txtMaLop.Text;
                }
                //newRow["MaLop"] = txtMaLop.Text;
                //newRow["MaKhoa"] = txtMaKhoa.Text;

                // Thêm dòng vào DataTable
                qlsvDataSet.SINHVIEN.Rows.Add(newRow);
                dgvSinhVien.Refresh();
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi thêm sinh viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow != null)
            {
                // Lấy DataRow hiện tại dựa trên DataBoundItem
                DataRowView rowView = dgvSinhVien.CurrentRow.DataBoundItem as DataRowView;
                if (rowView != null)
                {
                    DataRow rowToDelete = rowView.Row;
                    rowToDelete.Delete(); // Đánh dấu dòng này để xóa
                }

                // Làm mới hiển thị của DataGridView
                dgvSinhVien.Refresh();
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow != null)
            {
                // Lấy DataRow hiện tại dựa trên DataBoundItem
                DataRowView rowView = dgvSinhVien.CurrentRow.DataBoundItem as DataRowView;
                if (rowView != null)
                {
                    DataRow rowToEdit = rowView.Row;

                    // Cập nhật giá trị trong DataRow từ các TextBox
                    rowToEdit["HoTen"] = txtHoTen.Text;
                    //rowToEdit["NgaySinh"] = DateTime.Parse(txtNgaySinh.Text);
                    rowToEdit["NgaySinh"] = DateTime.Parse(dtpNgaySinh.Text);
                    //rowToEdit["GioiTinh"] = txtGioiTinh.Text;
                    rowToEdit["GioiTinh"] = cboGioiTinh.SelectedItem.ToString();
                    rowToEdit["DiaChi"] = txtDiaChi.Text;
                    rowToEdit["Email"] = txtEmail.Text;
                    rowToEdit["SDT"] = txtSDT.Text;
                    //rowToEdit["TrangThai"] = txtTrangThai.Text;
                    rowToEdit["TrangThai"] = cboTrangThai.SelectedItem.ToString();
                    if (MaNguoiDung != null)
                    {
                        rowToEdit["MaKhoa"] = cboFillterKhoa.SelectedValue.ToString();
                        rowToEdit["MaLop"] = cboFillterLop.SelectedValue.ToString();
                    }
                    else
                    {
                        rowToEdit["MaKhoa"] = txtMaKhoa.Text;
                        rowToEdit["MaLop"] = txtMaLop.Text;
                    }
                    //rowToEdit["MaLop"] = txtMaLop.Text;
                    //rowToEdit["MaKhoa"] = txtMaKhoa.Text;

                    // Làm mới hiển thị của DataGridView
                    dgvSinhVien.Refresh();
                    btnLuu.Enabled = true;
                    btnHuy.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                sinhvienTableAdapter.Update(qlsvDataSet.SINHVIEN);
                qlsvDataSet.AcceptChanges();
                MessageBox.Show("Lưu thay đổi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi lưu thay đổi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            qlsvDataSet.SINHVIEN.RejectChanges();
            dgvSinhVien.Refresh();
            MessageBox.Show("Đã hủy các thay đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }


        private void dgvSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow != null)
            {
                // Lấy DataRow hiện tại dựa trên DataBoundItem
                DataRowView rowView = dgvSinhVien.CurrentRow.DataBoundItem as DataRowView;
                if (rowView != null)
                {
                    DataRow row = rowView.Row;
                    // Hiển thị thông tin từ DataRow lên các TextBox
                    txtMaSV.Text = row["MaSV"].ToString().Trim();
                    txtHoTen.Text = row["HoTen"].ToString();
                    dtpNgaySinh.Value = DateTime.Parse(row["NgaySinh"].ToString());
                    //txtNgaySinh.Text = DateTime.Parse(row["NgaySinh"].ToString()).ToString("MM/dd/yyyy");
                    //txtGioiTinh.Text = row["GioiTinh"].ToString();
                    cboGioiTinh.SelectedIndex = row["GioiTinh"].ToString() == "Nam" ? 0 : 1;
                    txtDiaChi.Text = row["DiaChi"].ToString();
                    txtEmail.Text = row["Email"].ToString();
                    txtSDT.Text = row["SDT"].ToString();
                    //txtTrangThai.Text = row["TrangThai"].ToString();
                    cboTrangThai.SelectedIndex = row["TrangThai"].ToString() == "đang học" ? 0 : row["TrangThai"].ToString() == "thôi học" ? 1 : 2;
                    txtMaLop.Text = row["MaLop"].ToString().Trim();
                    txtMaKhoa.Text = row["MaKhoa"].ToString().Trim();
                }
            }
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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvSinhVien.ClearSelection();
            dgvSinhVien.Refresh();
            txtMaSV.Text = "";
            txtHoTen.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            //txtNgaySinh.Text = "";
            //txtGioiTinh.Text = "";
            cboGioiTinh.SelectedIndex = 0;
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            //txtTrangThai.Text = "";
            cboTrangThai.SelectedIndex = 0;
            if (MaNguoiDung != null)
            {
                txtMaKhoa.Text = cboFillterKhoa.SelectedValue.ToString();
                txtMaLop.Text = cboFillterLop.SelectedValue.ToString();
            }
            else
            {
                txtMaKhoa.Text = "";
                txtMaLop.Text = "";
            }
            //txtMaLop.Text = "";
            //txtMaKhoa.Text = "";
        }
    }
}
