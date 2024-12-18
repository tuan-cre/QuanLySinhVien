using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AZJ
{
    public partial class frmMonHoc : Form
    {
        public frmMonHoc()
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

        private void MonHocForm_Load(object sender, EventArgs e)
        {
            DataTable dt = this.bomonTableAdapter.GetData();
            DataRow dr = dt.NewRow();
            dr["MaBM"] = "All";
            dr["TenBM"] = "All";
            dt.Rows.InsertAt(dr, 0);
            cboFillterBoMon.DataSource = dt;
            cboFillterBoMon.DisplayMember = "TenBM";
            cboFillterBoMon.ValueMember = "MaBM";
            cboFillterBoMon.SelectedIndex = 0;
            this.monhocTableAdapter.Fill(this.qlsvDataSet.MONHOC);
        }

        private void cboFillterBoMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFillterBoMon.SelectedValue.ToString() != "All")
            {
                this.monhocTableAdapter.FillByMaBM(this.qlsvDataSet.MONHOC, cboFillterBoMon.SelectedValue.ToString());
            }
            else
            {
                this.monhocTableAdapter.Fill(this.qlsvDataSet.MONHOC);
            }
        }

        private void txtFillterMonHoc_TextChanged(object sender, EventArgs e)
        {
            if (cboFillterBoMon.SelectedValue.ToString() != "All")
            {
                this.monhocTableAdapter.FillByMaBMMaMH(this.qlsvDataSet.MONHOC, cboFillterBoMon.SelectedValue.ToString(), txtFillterMonHoc.Text);
            }
            else
            {
                this.monhocTableAdapter.FillByMaMH(this.qlsvDataSet.MONHOC, txtFillterMonHoc.Text);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newRow = qlsvDataSet.MONHOC.NewRow();
                newRow["MaMH"] = txtMaMH.Text;
                newRow["TenMH"] = txtTenMH.Text;
                newRow["STC"] = txtSTC.Text;
                newRow["MaBM"] = txtMaBM.Text;
                qlsvDataSet.MONHOC.Rows.Add(newRow);
                dgvMonHoc.Refresh();
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm môn học: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvMonHoc.CurrentRow != null)
            {
                DataRowView rowView = dgvMonHoc.CurrentRow.DataBoundItem as DataRowView;
                if (rowView != null)
                {
                    DataRow row = rowView.Row;
                    row["MaMH"] = txtMaMH.Text;
                    row["TenMH"] = txtTenMH.Text;
                    row["STC"] = txtSTC.Text;
                    row["MaBM"] = txtMaBM.Text;
                }
                dgvMonHoc.Refresh();
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn môn học để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvMonHoc.CurrentRow != null)
            {
                DataRowView rowView = dgvMonHoc.CurrentRow.DataBoundItem as DataRowView;
                if (rowView != null)
                {
                    DataRow rowToDelete = rowView.Row;
                    rowToDelete.Delete();
                }
                dgvMonHoc.Refresh();
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn môn học để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.monhocBindingSource.EndEdit();
                this.monhocTableAdapter.Update(this.qlsvDataSet.MONHOC);
                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            qlsvDataSet.MONHOC.RejectChanges();
            dgvMonHoc.Refresh();
            MessageBox.Show("Đã hủy các thay đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvMonHoc.ClearSelection();
            dgvMonHoc.Refresh();
            txtMaMH.Text = "";
            txtTenMH.Text = "";
            txtSTC.Text = "";
            txtMaBM.Text = "";
        }

        private void dgvMonHoc_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMonHoc.CurrentRow != null)
            {
                DataRowView rowView = dgvMonHoc.CurrentRow.DataBoundItem as DataRowView;
                if (rowView != null)
                {
                    DataRow row = rowView.Row;
                    txtMaMH.Text = row["MaMH"].ToString().Trim();
                    txtTenMH.Text = row["TenMH"].ToString();
                    txtSTC.Text = row["STC"].ToString();
                    txtMaBM.Text = row["MaBM"].ToString().Trim();
                }
            }
        }
    }
}
