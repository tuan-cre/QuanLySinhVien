using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
                DataRowView rowView = dgvGiangVien.CurrentRow.DataBoundItem as DataRowView;
                if (rowView != null)
                {
                    DataRow row = rowView.Row;
                    txtMaGV.Text = row["MaGV"].ToString().Trim();
                    txtHoTen.Text = row["HoTen"].ToString();
                    dtpNgaySinh.Value = DateTime.Parse(row["NgaySinh"].ToString());
                    cboGioiTinh.SelectedIndex = row["GioiTinh"].ToString() == "Nam" ? 0 : 1;
                    txtDiaChi.Text = row["DiaChi"].ToString();
                    txtEmail.Text = row["Email"].ToString();
                    txtSDT.Text = row["SDT"].ToString();
                    txtMaKhoa.Text = row["MaKhoa"].ToString().Trim();
                    txtMaBM.Text = row["MaBM"].ToString().Trim();
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
