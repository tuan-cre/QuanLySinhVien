using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AZJ
{
    public partial class frmHocKy : Form
    {
        public frmHocKy()
        {
            InitializeComponent();
        }

        private void dgvHocKy_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHocKy.CurrentRow != null)
            {
                txtMaHK.Text = dgvHocKy.CurrentRow.Cells["MaHK"].Value.ToString().Trim();
                txtTenHK.Text = dgvHocKy.CurrentRow.Cells["TenHK"].Value.ToString();
                txtNamHoc.Text = dgvHocKy.CurrentRow.Cells["NamHoc"].Value.ToString();
                dtpNgayBD.Value = DateTime.Parse(dgvHocKy.CurrentRow.Cells["NgayBD"].Value.ToString());
                dtpNgayKT.Value = DateTime.Parse(dgvHocKy.CurrentRow.Cells["NgayKT"].Value.ToString());
            }
        }

        private void frmHocKy_Load(object sender, EventArgs e)
        {
            this.hockyTableAdapter.Fill(this.qlsvDataSet.HOCKY);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newRow = qlsvDataSet.HOCKY.NewRow();
                newRow["MaHK"] = txtMaHK.Text;
                newRow["TenHK"] = txtTenHK.Text;
                newRow["NamHoc"] = txtNamHoc.Text;
                newRow["NgayBD"] = dtpNgayBD.Value;
                newRow["NgayKT"] = dtpNgayKT.Value;
                qlsvDataSet.HOCKY.Rows.Add(newRow);
                dgvHocKy.Refresh();
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
            if (dgvHocKy.CurrentRow != null)
            {
                DataRowView rowView = dgvHocKy.CurrentRow.DataBoundItem as DataRowView;
                DataRow rowToEdit = rowView.Row;
                rowToEdit["MaHK"] = txtMaHK.Text;
                rowToEdit["TenHK"] = txtTenHK.Text;
                rowToEdit["NamHoc"] = txtNamHoc.Text;
                rowToEdit["NgayBD"] = dtpNgayBD.Value;
                rowToEdit["NgayKT"] = dtpNgayKT.Value;
                dgvHocKy.Refresh();
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn học kỳ để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHocKy.CurrentRow != null)
            {
                DataRowView rowView = dgvHocKy.CurrentRow.DataBoundItem as DataRowView;
                if (rowView != null)
                {
                    DataRow rowToDelete = rowView.Row;
                    rowToDelete.Delete();
                }
                dgvHocKy.Refresh();
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn học kỳ để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.hockyBindingSource.EndEdit();
                this.hockyTableAdapter.Update(this.qlsvDataSet.HOCKY);
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
            this.qlsvDataSet.HOCKY.RejectChanges();
            dgvHocKy.Refresh();
            MessageBox.Show("Đã hủy các thay đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvHocKy.ClearSelection();
            dgvHocKy.Refresh();
            txtMaHK.Text = "";
            txtTenHK.Text = "";
            txtNamHoc.Text = "";
            dtpNgayBD.Value = DateTime.Now;
            dtpNgayKT.Value = DateTime.Now;
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
