using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AZJ
{
    public partial class frmKhoa : Form
    {
        public frmKhoa()
        {
            InitializeComponent();
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            this.khoaTableAdapter.Fill(this.qlsvDataSet.KHOA);
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

        private void txtFillterMaKhoa_TextChanged(object sender, EventArgs e)
        {
            if (txtFillterMaKhoa.Text != "")
            {
                this.khoaTableAdapter.FillByMaKhoa(this.qlsvDataSet.KHOA, txtFillterMaKhoa.Text);
            }
            else
            {
                this.khoaTableAdapter.Fill(this.qlsvDataSet.KHOA);
            }
        }

        private void dgvKhoa_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKhoa.CurrentRow != null)
            {
                txtMaKhoa.Text = dgvKhoa.CurrentRow.Cells["MaKhoa"].Value.ToString().Trim();
                txtTenKhoa.Text = dgvKhoa.CurrentRow.Cells["TenKhoa"].Value.ToString();
                txtTruongKhoa.Text = dgvKhoa.CurrentRow.Cells["TruongKhoa"].Value.ToString();
                txtDiaChi.Text = dgvKhoa.CurrentRow.Cells["DiaChi"].Value.ToString();
                txtSDT.Text = dgvKhoa.CurrentRow.Cells["SDT"].Value.ToString();
                txtEmail.Text = dgvKhoa.CurrentRow.Cells["Email"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dataRow = this.qlsvDataSet.KHOA.NewRow();
                dataRow["MaKhoa"] = txtMaKhoa.Text;
                dataRow["TenKhoa"] = txtTenKhoa.Text;
                dataRow["TruongKhoa"] = txtTruongKhoa.Text;
                dataRow["DiaChi"] = txtDiaChi.Text;
                dataRow["SDT"] = txtSDT.Text;
                dataRow["Email"] = txtEmail.Text;
                this.qlsvDataSet.KHOA.Rows.Add(dataRow);
                dgvKhoa.Refresh();
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
            if (dgvKhoa.CurrentRow != null)
            {
                DataRowView rowView = dgvKhoa.CurrentRow.DataBoundItem as DataRowView;
                DataRow rowToEdit = rowView.Row;
                rowToEdit["MaKhoa"] = txtMaKhoa.Text;
                rowToEdit["TenKhoa"] = txtTenKhoa.Text;
                rowToEdit["TruongKhoa"] = txtTruongKhoa.Text;
                rowToEdit["DiaChi"] = txtDiaChi.Text;
                rowToEdit["SDT"] = txtSDT.Text;
                rowToEdit["Email"] = txtEmail.Text;
                dgvKhoa.Refresh();
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khoa để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhoa.CurrentRow != null)
            {
                DataRowView rowView = dgvKhoa.CurrentRow.DataBoundItem as DataRowView;
                if (rowView != null)
                {
                    DataRow rowToDelete = rowView.Row;
                    rowToDelete.Delete();
                }
                dgvKhoa.Refresh();
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khoa để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.kHOABindingSource.EndEdit();
                this.khoaTableAdapter.Update(this.qlsvDataSet.KHOA);
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
            qlsvDataSet.KHOA.RejectChanges();
            dgvKhoa.Refresh();
            MessageBox.Show("Đã hủy các thay đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvKhoa.ClearSelection();
            dgvKhoa.Refresh();
            txtMaKhoa.Text = "";
            txtTenKhoa.Text = "";
            txtTruongKhoa.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
        }
    }
}
