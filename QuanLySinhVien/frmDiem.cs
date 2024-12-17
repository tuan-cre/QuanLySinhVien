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
    public partial class frmDiem : Form
    {
        public frmDiem()
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

        private void DiemForm_Load(object sender, EventArgs e)
        {
            DataTable dt = this.monhocTableAdapter.GetData();
            DataRow dr = dt.NewRow();
            dr["MaMH"] = "All";
            dr["TenMH"] = "All";
            dt.Rows.InsertAt(dr, 0);
            cboFillterMonHoc.DataSource = dt;
            cboFillterMonHoc.DisplayMember = "TenMH";
            cboFillterMonHoc.ValueMember = "MaMH";
            cboFillterMonHoc.SelectedIndex = 0;
            DataTable dt2 = this.hockyTableAdapter.GetData();
            DataRow dr2 = dt2.NewRow();
            dr2["MaHK"] = "All";
            dr2["TenHK"] = "All";
            dr2["NamHoc"] = "All";
            dt2.Rows.InsertAt(dr2, 0);
            cboFillterHocKy.DataSource = dt2;
            cboFillterHocKy.DisplayMember = "TenHK";
            cboFillterHocKy.ValueMember = "MaHK";
            cboFillterHocKy.SelectedIndex = 0;

            this.diemTableAdapter.Fill(this.qLSVDataSet.DIEM);
        }

        private void cboFillterMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFillterMonHoc.SelectedValue.ToString() != "All")
            {
                this.diemTableAdapter.FillByMaMH(this.qLSVDataSet.DIEM, cboFillterMonHoc.SelectedValue.ToString());
            }
            else
            {
                this.diemTableAdapter.Fill(this.qLSVDataSet.DIEM);
            }
        }

        private void cboFillterHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFillterHocKy.SelectedValue.ToString() != "All")
            {
                if (cboFillterMonHoc.SelectedValue.ToString() != "All")
                {
                    this.diemTableAdapter.FillByMaMHMaHK(this.qLSVDataSet.DIEM, cboFillterMonHoc.SelectedValue.ToString(), cboFillterHocKy.SelectedValue.ToString());
                }
                else
                {
                    this.diemTableAdapter.FillByMaHK(this.qLSVDataSet.DIEM, cboFillterHocKy.SelectedValue.ToString());
                }
            }
            else
            {
                this.diemTableAdapter.Fill(this.qLSVDataSet.DIEM);
            }
        }

        private void dgvDiem_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDiem.CurrentRow != null)
            {
                txtMaDiem.Text = dgvDiem.CurrentRow.Cells["MaDiem"].Value.ToString();
                txtMaSV.Text = dgvDiem.CurrentRow.Cells["MaSV"].Value.ToString().Trim();
                txtMaMH.Text = dgvDiem.CurrentRow.Cells["MaMH"].Value.ToString().Trim();
                txtMaHK.Text = dgvDiem.CurrentRow.Cells["MaHK"].Value.ToString().Trim();
                txtDiemGiuaKy.Text = dgvDiem.CurrentRow.Cells["DiemGiuaKy"].Value.ToString();
                txtDiemCuoiKy.Text = dgvDiem.CurrentRow.Cells["DiemCuoiKy"].Value.ToString();
                txtDiemTongKet.Text = dgvDiem.CurrentRow.Cells["DiemTongKet"].Value.ToString();
                txtTrangThai.Text = dgvDiem.CurrentRow.Cells["TrangThai"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newRow = qLSVDataSet.DIEM.NewRow();
                newRow["MaDiem"] = 0;
                newRow["MaSV"] = txtMaSV.Text;
                newRow["MaMH"] = txtMaMH.Text;
                newRow["MaHK"] = txtMaHK.Text;
                if (txtDiemGiuaKy.Text != "")
                {
                    newRow["DiemGiuaKy"] = float.Parse(txtDiemGiuaKy.Text);
                    if (txtDiemCuoiKy.Text != "")
                    {
                        newRow["DiemCuoiKy"] = float.Parse(txtDiemCuoiKy.Text);
                        double dtk = (float.Parse(txtDiemGiuaKy.Text) * 0.4 + float.Parse(txtDiemCuoiKy.Text) * 0.6);
                        newRow["DiemTongKet"] = dtk;
                        newRow["TrangThai"] = dtk >= 5 ? "Đạt" : "Không đạt";
                    }
                    else
                        newRow["TrangThai"] = "Chưa Hoàn Thành";
                }
                else
                    newRow["TrangThai"] = "Chưa Hoàn Thành";

                qLSVDataSet.DIEM.Rows.Add(newRow);
                dgvDiem.Refresh();
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
            if (dgvDiem.CurrentRow != null)
            {
                DataRowView rowView = dgvDiem.CurrentRow.DataBoundItem as DataRowView;
                DataRow rowToEdit = rowView.Row;
                rowToEdit["MaSV"] = txtMaSV.Text;
                rowToEdit["MaMH"] = txtMaMH.Text;
                rowToEdit["MaHK"] = txtMaHK.Text;
                if (txtDiemGiuaKy.Text != "")
                {
                    rowToEdit["DiemGiuaKy"] = txtDiemGiuaKy.Text;
                    if (txtDiemCuoiKy.Text != "")
                    {
                        rowToEdit["DiemCuoiKy"] = txtDiemCuoiKy.Text;
                        double dtk = (float.Parse(txtDiemGiuaKy.Text) * 0.4 + float.Parse(txtDiemCuoiKy.Text) * 0.6);
                        rowToEdit["TrangThai"] = dtk >= 5 ? "Đạt" : "Không đạt";
                    }
                }    

                dgvDiem.Refresh();
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn điểm để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDiem.CurrentRow != null)
            {
                DataRowView rowView = dgvDiem.CurrentRow.DataBoundItem as DataRowView;
                if (rowView != null)
                {
                    DataRow rowToDelete = rowView.Row;
                    rowToDelete.Delete();
                }
                dgvDiem.Refresh();
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn điểm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.diemBindingSource.EndEdit();
                this.diemTableAdapter.Update(this.qLSVDataSet.DIEM);
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
            qLSVDataSet.DIEM.RejectChanges();
            dgvDiem.Refresh();
            MessageBox.Show("Đã hủy các thay đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvDiem.ClearSelection();
            dgvDiem.Refresh();
            txtMaDiem.Text = "";
            txtMaSV.Text = "";
            txtMaMH.Text = "";
            txtMaHK.Text = "";
            txtDiemGiuaKy.Text = "";
            txtDiemCuoiKy.Text = "";
            txtDiemTongKet.Text = "";
            txtTrangThai.Text = "";
        }

    }
}
