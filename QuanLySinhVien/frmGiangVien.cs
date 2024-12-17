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
    public partial class frmGiangVien : Form
    {
        public frmGiangVien()
        {
            InitializeComponent();
        }

        private void frmGiangVien_Load(object sender, EventArgs e)
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
            this.giangvienTableAdapter.Fill(this.qlsvDataSet.GIANGVIEN);
        }

        private void cboFillterKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFillterKhoa.SelectedValue.ToString() == "All")
            {
                this.giangvienTableAdapter.Fill(this.qlsvDataSet.GIANGVIEN);
            }
            else
            {
                this.giangvienTableAdapter.FillByMaKhoa(this.qlsvDataSet.GIANGVIEN, cboFillterKhoa.SelectedValue.ToString());
            }
        }

        private void txtFillterMaGV_TextChanged(object sender, EventArgs e)
        {
            if (cboFillterKhoa.SelectedValue.ToString() == "All")
            {
                this.giangvienTableAdapter.FillByMaGV(this.qlsvDataSet.GIANGVIEN, txtFillterMaGV.Text);
            }
            else
            {
                this.giangvienTableAdapter.FillByMaGVMaKhoa(this.qlsvDataSet.GIANGVIEN, txtFillterMaGV.Text, cboFillterKhoa.SelectedValue.ToString());
            }
        }

        private void dgvSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGiangVien.CurrentRow != null)
            {
                // Lấy DataRow hiện tại dựa trên DataBoundItem
                DataRowView rowView = dgvGiangVien.CurrentRow.DataBoundItem as DataRowView;
                if (rowView != null)
                {
                    DataRow row = rowView.Row;
                    // Hiển thị thông tin từ DataRow lên các TextBox
                    txtMaGV.Text = row["MaGV"].ToString().Trim();
                    txtHoTen.Text = row["HoTen"].ToString();
                    dtpNgaySinh.Value = DateTime.Parse(row["NgaySinh"].ToString());
                    //txtNgaySinh.Text = DateTime.Parse(row["NgaySinh"].ToString()).ToString("MM/dd/yyyy");
                    //txtGioiTinh.Text = row["GioiTinh"].ToString();
                    cboGioiTinh.SelectedIndex = row["GioiTinh"].ToString() == "Nam" ? 0 : 1;
                    txtDiaChi.Text = row["DiaChi"].ToString();
                    txtEmail.Text = row["Email"].ToString();
                    txtSDT.Text = row["SDT"].ToString();
                    //txtTrangThai.Text = row["TrangThai"].ToString();
                    txtMaKhoa.Text = row["MaKhoa"].ToString().Trim();
                    txtMaBM.Text = row["MaBM"].ToString().Trim();
                }
            }
        }

        //private void btnThem_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        // Tạo một dòng mới trong DataTable
        //        DataRow newRow = qlsvDataSet.SINHVIEN.NewRow();
        //        newRow["MaSV"] = txtMaSV.Text;
        //        newRow["HoTen"] = txtHoTen.Text;
        //        //newRow["NgaySinh"] = DateTime.Parse(txtNgaySinh.Text);
        //        newRow["NgaySinh"] = DateTime.Parse(dtpNgaySinh.Text);
        //        //newRow["GioiTinh"] = txtGioiTinh.Text;
        //        newRow["GioiTinh"] = cboGioiTinh.SelectedItem.ToString();
        //        newRow["DiaChi"] = txtDiaChi.Text;
        //        newRow["Email"] = txtEmail.Text;
        //        newRow["SDT"] = txtSDT.Text;
        //        //newRow["TrangThai"] = txtTrangThai.Text;
        //        newRow["TrangThai"] = cboTrangThai.SelectedItem.ToString();
        //        newRow["MaLop"] = txtMaLop.Text;
        //        newRow["MaKhoa"] = txtMaKhoa.Text;

        //        // Thêm dòng vào DataTable
        //        qlsvDataSet.SINHVIEN.Rows.Add(newRow);
        //        dgvSinhVien.Refresh();
        //        btnLuu.Enabled = true;
        //        btnHuy.Enabled = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Đã xảy ra lỗi khi thêm sinh viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void btnXoa_Click(object sender, EventArgs e)
        //{
        //    if (dgvSinhVien.CurrentRow != null)
        //    {
        //        // Lấy DataRow hiện tại dựa trên DataBoundItem
        //        DataRowView rowView = dgvSinhVien.CurrentRow.DataBoundItem as DataRowView;
        //        if (rowView != null)
        //        {
        //            DataRow rowToDelete = rowView.Row;
        //            rowToDelete.Delete(); // Đánh dấu dòng này để xóa
        //        }

        //        // Làm mới hiển thị của DataGridView
        //        dgvSinhVien.Refresh();
        //        btnLuu.Enabled = true;
        //        btnHuy.Enabled = true;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui lòng chọn sinh viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}


        //private void btnSua_Click(object sender, EventArgs e)
        //{
        //    if (dgvSinhVien.CurrentRow != null)
        //    {
        //        // Lấy DataRow hiện tại dựa trên DataBoundItem
        //        DataRowView rowView = dgvSinhVien.CurrentRow.DataBoundItem as DataRowView;
        //        if (rowView != null)
        //        {
        //            DataRow rowToEdit = rowView.Row;

        //            // Cập nhật giá trị trong DataRow từ các TextBox
        //            rowToEdit["HoTen"] = txtHoTen.Text;
        //            //rowToEdit["NgaySinh"] = DateTime.Parse(txtNgaySinh.Text);
        //            rowToEdit["NgaySinh"] = DateTime.Parse(dtpNgaySinh.Text);
        //            //rowToEdit["GioiTinh"] = txtGioiTinh.Text;
        //            rowToEdit["GioiTinh"] = cboGioiTinh.SelectedItem.ToString();
        //            rowToEdit["DiaChi"] = txtDiaChi.Text;
        //            rowToEdit["Email"] = txtEmail.Text;
        //            rowToEdit["SDT"] = txtSDT.Text;
        //            //rowToEdit["TrangThai"] = txtTrangThai.Text;
        //            rowToEdit["TrangThai"] = cboTrangThai.SelectedItem.ToString();
        //            rowToEdit["MaLop"] = txtMaLop.Text;
        //            rowToEdit["MaKhoa"] = txtMaKhoa.Text;

        //            // Làm mới hiển thị của DataGridView
        //            dgvSinhVien.Refresh();
        //            btnLuu.Enabled = true;
        //            btnHuy.Enabled = true;
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui lòng chọn sinh viên để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}

        //private void btnLuu_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        sinhvienTableAdapter.Update(qlsvDataSet.SINHVIEN);
        //        qlsvDataSet.AcceptChanges();
        //        MessageBox.Show("Lưu thay đổi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        btnLuu.Enabled = false;
        //        btnHuy.Enabled = false;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Đã xảy ra lỗi khi lưu thay đổi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void btnHuy_Click(object sender, EventArgs e)
        //{
        //    qlsvDataSet.SINHVIEN.RejectChanges();
        //    dgvSinhVien.Refresh();
        //    MessageBox.Show("Đã hủy các thay đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    btnLuu.Enabled = false;
        //    btnHuy.Enabled = false;
        //}


        //private void dgvSinhVien_SelectionChanged(object sender, EventArgs e)
        //{
        //    if (dgvSinhVien.CurrentRow != null)
        //    {
        //        // Lấy DataRow hiện tại dựa trên DataBoundItem
        //        DataRowView rowView = dgvSinhVien.CurrentRow.DataBoundItem as DataRowView;
        //        if (rowView != null)
        //        {
        //            DataRow row = rowView.Row;
        //            // Hiển thị thông tin từ DataRow lên các TextBox
        //            txtMaSV.Text = row["MaSV"].ToString().Trim();
        //            txtHoTen.Text = row["HoTen"].ToString();
        //            dtpNgaySinh.Value = DateTime.Parse(row["NgaySinh"].ToString());
        //            //txtNgaySinh.Text = DateTime.Parse(row["NgaySinh"].ToString()).ToString("MM/dd/yyyy");
        //            //txtGioiTinh.Text = row["GioiTinh"].ToString();
        //            cboGioiTinh.SelectedIndex = row["GioiTinh"].ToString() == "Nam" ? 0 : 1;
        //            txtDiaChi.Text = row["DiaChi"].ToString();
        //            txtEmail.Text = row["Email"].ToString();
        //            txtSDT.Text = row["SDT"].ToString();
        //            //txtTrangThai.Text = row["TrangThai"].ToString();
        //            cboTrangThai.SelectedIndex = row["TrangThai"].ToString() == "đang học" ? 0 : row["TrangThai"].ToString() == "thôi học" ? 1 : 2;
        //            txtMaLop.Text = row["MaLop"].ToString().Trim();
        //            txtMaKhoa.Text = row["MaKhoa"].ToString().Trim();
        //        }
        //    }
        //}


        //private void btnLamMoi_Click(object sender, EventArgs e)
        //{
        //    dgvSinhVien.ClearSelection();
        //    dgvSinhVien.Refresh();
        //    txtMaSV.Text = "";
        //    txtHoTen.Text = "";
        //    dtpNgaySinh.Value = DateTime.Now;
        //    //txtNgaySinh.Text = "";
        //    //txtGioiTinh.Text = "";
        //    cboGioiTinh.SelectedIndex = 0;
        //    txtDiaChi.Text = "";
        //    txtEmail.Text = "";
        //    txtSDT.Text = "";
        //    //txtTrangThai.Text = "";
        //    cboTrangThai.SelectedIndex = 0;
        //    txtMaLop.Text = "";
        //    txtMaKhoa.Text = "";
        //}
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dataRow = qlsvDataSet.GIANGVIEN.NewRow();
                dataRow["MaGV"] = txtMaGV.Text;
                dataRow["HoTen"] = txtHoTen.Text;
                dataRow["NgaySinh"] = dtpNgaySinh.Value;
                dataRow["GioiTinh"] = cboGioiTinh.SelectedItem.ToString();
                dataRow["DiaChi"] = txtDiaChi.Text;
                dataRow["Email"] = txtEmail.Text;
                dataRow["SDT"] = txtSDT.Text;
                dataRow["MaKhoa"] = txtMaKhoa.Text;
                dataRow["MaBM"] = txtMaBM.Text;
                qlsvDataSet.GIANGVIEN.Rows.Add(dataRow);
                dgvGiangVien.Refresh();
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
            if (dgvGiangVien.CurrentRow != null)
            {
                DataRowView rowView = dgvGiangVien.CurrentRow.DataBoundItem as DataRowView;
                DataRow rowToEdit = rowView.Row;
                rowToEdit["MaGV"] = txtMaGV.Text;
                rowToEdit["HoTen"] = txtHoTen.Text;
                rowToEdit["NgaySinh"] = dtpNgaySinh.Value;
                rowToEdit["GioiTinh"] = cboGioiTinh.SelectedItem.ToString();
                rowToEdit["DiaChi"] = txtDiaChi.Text;
                rowToEdit["Email"] = txtEmail.Text;
                rowToEdit["SDT"] = txtSDT.Text;
                rowToEdit["MaKhoa"] = txtMaKhoa.Text;
                rowToEdit["MaBM"] = txtMaBM.Text;
                dgvGiangVien.Refresh();
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvGiangVien.CurrentRow != null)
            {
                DataRowView rowView = dgvGiangVien.CurrentRow.DataBoundItem as DataRowView;
                if (rowView != null)
                {
                    DataRow rowToDelete = rowView.Row;
                    rowToDelete.Delete();
                }
                dgvGiangVien.Refresh();
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn giảng viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                giangvienTableAdapter.Update(qlsvDataSet.GIANGVIEN);
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
            qlsvDataSet.GIANGVIEN.RejectChanges();
            dgvGiangVien.Refresh();
            MessageBox.Show("Đã hủy các thay đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvGiangVien.ClearSelection();
            dgvGiangVien.Refresh();
            txtMaGV.Text = "";
            txtHoTen.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            cboGioiTinh.SelectedIndex = 0;
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            txtMaKhoa.Text = "";
            txtMaBM.Text = "";
        }
    }
}
