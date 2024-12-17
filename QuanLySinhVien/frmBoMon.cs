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
    public partial class frmBoMon : Form
    {
        public frmBoMon()
        {
            InitializeComponent();
        }

        private void cboFillterKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFillterKhoa.SelectedValue.ToString() == "All")
            {
                this.bomonTableAdapter.Fill(this.qlsvDataSet.BOMON);
            }
            else
            {
                this.bomonTableAdapter.FillByMaKhoa(this.qlsvDataSet.BOMON, cboFillterKhoa.SelectedValue.ToString());
            }
        }

        private void frmBoMon_Load(object sender, EventArgs e)
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
            this.bomonTableAdapter.Fill(this.qlsvDataSet.BOMON);
        }

        private void txtFillterBoMon_TextChanged(object sender, EventArgs e)
        {
            if (cboFillterKhoa.SelectedValue.ToString() == "All")
            {
                this.bomonTableAdapter.FillByMaBM(this.qlsvDataSet.BOMON, txtFillterBoMon.Text);
            }
            else
            {
                this.bomonTableAdapter.FillByMaBMMaKhoa(this.qlsvDataSet.BOMON, txtFillterBoMon.Text, cboFillterKhoa.SelectedValue.ToString());
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

        private void dgvMonHoc_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBoMon.CurrentRow != null)
            {
                txtMaBM.Text = dgvBoMon.CurrentRow.Cells["MaBM"].Value.ToString().Trim();
                txtTenBM.Text = dgvBoMon.CurrentRow.Cells["TenBM"].Value.ToString();
                txtTruongBM.Text = dgvBoMon.CurrentRow.Cells["TruongBM"].Value.ToString();
                txtMaKhoa.Text = dgvBoMon.CurrentRow.Cells["MaKhoa"].Value.ToString().Trim();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dataRow = qlsvDataSet.BOMON.NewRow();
                dataRow["MaBM"] = txtMaBM.Text;
                dataRow["TenBM"] = txtTenBM.Text;
                dataRow["TruongBM"] = txtTruongBM.Text;
                dataRow["MaKhoa"] = txtMaKhoa.Text;
                qlsvDataSet.BOMON.Rows.Add(dataRow);
                dgvBoMon.Refresh();
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
            if (dgvBoMon.CurrentRow != null)
            {
                DataRowView rowView = dgvBoMon.CurrentRow.DataBoundItem as DataRowView;
                DataRow rowToEdit = rowView.Row;
                rowToEdit["MaBM"] = txtMaBM.Text;
                rowToEdit["TenBM"] = txtTenBM.Text;
                rowToEdit["TruongBM"] = txtTruongBM.Text;
                rowToEdit["MaKhoa"] = txtMaKhoa.Text;
                dgvBoMon.Refresh();
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bộ môn để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvBoMon.CurrentRow != null)
            {
                DataRowView rowView = dgvBoMon.CurrentRow.DataBoundItem as DataRowView;
                if (rowView != null)
                {
                    DataRow rowToDelete = rowView.Row;
                    rowToDelete.Delete();
                }
                dgvBoMon.Refresh();
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bộ môn để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.bomonBindingSource.EndEdit();
                this.bomonTableAdapter.Update(this.qlsvDataSet.BOMON);
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
            qlsvDataSet.BOMON.RejectChanges();
            dgvBoMon.Refresh();
            MessageBox.Show("Đã hủy các thay đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvBoMon.ClearSelection();
            dgvBoMon.Refresh();
            txtMaBM.Text = "";
            txtTenBM.Text = "";
            txtTruongBM.Text = "";
            txtMaKhoa.Text = "";
        }
    }
}
