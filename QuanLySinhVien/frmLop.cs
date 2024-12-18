using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AZJ
{
    public partial class frmLop : Form
    {
        public frmLop()
        {
            InitializeComponent();
        }

        private void LopForm_Load(object sender, EventArgs e)
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
            this.lopTableAdapter.Fill(this.qlsvDataSet.LOP);
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

        private void cboFillterKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFillterKhoa.SelectedValue.ToString() != "All")
            {
                this.lopTableAdapter.FillByMaKhoa(this.qlsvDataSet.LOP, cboFillterKhoa.SelectedValue.ToString());
            }
            else
            {
                this.lopTableAdapter.Fill(this.qlsvDataSet.LOP);
            }
        }

        private void txtFillterMaLop_TextChanged(object sender, EventArgs e)
        {
            if (cboFillterKhoa.SelectedValue.ToString() != "All")
            {
                this.lopTableAdapter.FillByMaKhoaMaLop(this.qlsvDataSet.LOP, cboFillterKhoa.SelectedValue.ToString(), txtFillterMaLop.Text);
            }
            else
            {
                if (txtFillterMaLop.Text != "")
                {
                    this.lopTableAdapter.FillByMaLop(this.qlsvDataSet.LOP, txtFillterMaLop.Text);
                }
                else
                {
                    this.lopTableAdapter.Fill(this.qlsvDataSet.LOP);
                }
            }
        }

        private void dgvLop_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLop.CurrentRow != null)
            {
                txtMaLop.Text = dgvLop.CurrentRow.Cells["MaLop"].Value.ToString().Trim();
                txtTenLop.Text = dgvLop.CurrentRow.Cells["TenLop"].Value.ToString();
                txtMaKhoa.Text = dgvLop.CurrentRow.Cells["MaKhoa"].Value.ToString().Trim();
                txtMaBM.Text = dgvLop.CurrentRow.Cells["MaBM"].Value.ToString().Trim();
                txtSiSo.Text = dgvLop.CurrentRow.Cells["SiSo"].Value.ToString();
                txtKhoaHoc.Text = dgvLop.CurrentRow.Cells["KhoaHoc"].Value.ToString();
                txtMaGV.Text = dgvLop.CurrentRow.Cells["MaGV"].Value.ToString().Trim();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newRow = qlsvDataSet.LOP.NewRow();
                newRow["MaLop"] = txtMaLop.Text;
                newRow["TenLop"] = txtTenLop.Text;
                newRow["MaKhoa"] = txtMaKhoa.Text;
                newRow["MaBM"] = txtMaBM.Text;
                newRow["SiSo"] = txtSiSo.Text;
                newRow["KhoaHoc"] = txtKhoaHoc.Text;
                newRow["MaGV"] = txtMaGV.Text;
                qlsvDataSet.LOP.Rows.Add(newRow);
                dgvLop.Refresh();
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
            if (dgvLop.CurrentRow != null)
            {
                DataRowView rowView = dgvLop.CurrentRow.DataBoundItem as DataRowView;

                DataRow rowToEdit = rowView.Row;
                rowToEdit["MaLop"] = txtMaLop.Text;
                rowToEdit["TenLop"] = txtTenLop.Text;
                rowToEdit["MaKhoa"] = txtMaKhoa.Text;
                rowToEdit["MaBM"] = txtMaBM.Text;
                rowToEdit["SiSo"] = txtSiSo.Text;
                rowToEdit["KhoaHoc"] = txtKhoaHoc.Text;
                rowToEdit["MaGV"] = txtMaGV.Text;
                dgvLop.Refresh();
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lớp để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLop.CurrentRow != null)
            {
                DataRowView rowView = dgvLop.CurrentRow.DataBoundItem as DataRowView;
                if (rowView != null)
                {
                    DataRow rowToDelete = rowView.Row;
                    rowToDelete.Delete();
                }

                dgvLop.Refresh();
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lớp để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.lopBindingSource.EndEdit();
                this.lopTableAdapter.Update(this.qlsvDataSet.LOP);
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
            qlsvDataSet.LOP.RejectChanges();
            dgvLop.Refresh();
            MessageBox.Show("Đã hủy các thay đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvLop.ClearSelection();
            dgvLop.Refresh();
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            txtMaKhoa.Text = "";
            txtMaBM.Text = "";
            txtSiSo.Text = "";
            txtKhoaHoc.Text = "";
            txtMaGV.Text = "";
        }
    }
}
