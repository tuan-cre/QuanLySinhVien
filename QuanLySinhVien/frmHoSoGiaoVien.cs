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
    public partial class frmHoSoGiaoVien : Form
    {
        String MaNguoiDung;
        public frmHoSoGiaoVien(String Ma)
        {
            InitializeComponent();
            MaNguoiDung = Ma;
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

        private void HoSoGiaoVien_Load(object sender, EventArgs e)
        {
            loadThongTinGiaoVien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtHoTen.Enabled = true;
            dtpNgaySinh.Enabled = true;
            cboGioiTinh.Enabled = true;
            txtDiaChi.Enabled = true;
            txtEmail.Enabled = true;
            txtSDT.Enabled = true;
            btnLuu.Enabled = true;
            btnLuu.Visible = true;
            btnHuy.Enabled = true;
            btnHuy.Visible = true;
            btnSua.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            this.giangvienTableAdapter.UpdateHoSoGV(txtHoTen.Text, cboGioiTinh.Text, dtpNgaySinh.Text, txtEmail.Text, txtSDT.Text, txtDiaChi.Text, MaNguoiDung);
            MessageBox.Show("Cập nhật thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtHoTen.Enabled = false;
            dtpNgaySinh.Enabled = false;
            cboGioiTinh.Enabled = false;
            txtDiaChi.Enabled = false;
            txtEmail.Enabled = false;
            txtSDT.Enabled = false;
            btnLuu.Enabled = false;
            btnLuu.Visible = false;
            btnHuy.Enabled = false;
            btnHuy.Visible = false;
            btnSua.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtHoTen.Enabled = false;
            dtpNgaySinh.Enabled = false;
            cboGioiTinh.Enabled = false;
            txtDiaChi.Enabled = false;
            txtEmail.Enabled = false;
            txtSDT.Enabled = false;
            btnLuu.Enabled = false;
            btnLuu.Visible = false;
            btnHuy.Enabled = false;
            btnHuy.Visible = false;
            btnSua.Enabled = true;
            loadThongTinGiaoVien();
            MessageBox.Show("Hủy cập nhật thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void loadThongTinGiaoVien()
        {
            giangvienTableAdapter.FillByMaGV(qlsvDataSet.GIANGVIEN, MaNguoiDung.Trim() + '%');
            txtMaGV.Text = qlsvDataSet.GIANGVIEN.Rows[0]["MaGV"].ToString();
            txtHoTen.Text = qlsvDataSet.GIANGVIEN.Rows[0]["HoTen"].ToString();
            dtpNgaySinh.Text = qlsvDataSet.GIANGVIEN.Rows[0]["NgaySinh"].ToString();
            cboGioiTinh.SelectedIndex = qlsvDataSet.GIANGVIEN.Rows[0]["GioiTinh"].ToString() == "Nam" ? 0 : 1;
            txtDiaChi.Text = qlsvDataSet.GIANGVIEN.Rows[0]["DiaChi"].ToString();
            txtEmail.Text = qlsvDataSet.GIANGVIEN.Rows[0]["Email"].ToString();
            txtSDT.Text = qlsvDataSet.GIANGVIEN.Rows[0]["SDT"].ToString();
            txtMaBM.Text = qlsvDataSet.GIANGVIEN.Rows[0]["MaBM"].ToString();
            txtMaKhoa.Text = qlsvDataSet.GIANGVIEN.Rows[0]["MaKhoa"].ToString();
        }

    }
}
