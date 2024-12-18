using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AZJ
{
    public partial class frmHoSoTaiKhoan : Form
    {
        String MaNguoiDung;
        String LoaiTaiKhoan;
        public frmHoSoTaiKhoan(string maNguoiDung, string loaiTaiKhoan)
        {
            InitializeComponent();
            MaNguoiDung = maNguoiDung;
            LoaiTaiKhoan = loaiTaiKhoan;
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

        private void TaiKhoanForm_Load(object sender, EventArgs e)
        {
            if (LoaiTaiKhoan == "SV")
                this.taikhoanTableAdapter.FillByMaSV(this.qlsvDataSet.TAIKHOAN, MaNguoiDung);
            else
                this.taikhoanTableAdapter.FillByMaGV(this.qlsvDataSet.TAIKHOAN, MaNguoiDung);

            txtLoaiTaiKhoan.Text = qlsvDataSet.TAIKHOAN.Rows[0]["LoaiTaiKhoan"].ToString();
            txtTenDangNhap.Text = qlsvDataSet.TAIKHOAN.Rows[0]["TenDangNhap"].ToString();
            txtMatKhau.Text = qlsvDataSet.TAIKHOAN.Rows[0]["MatKhau"].ToString();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            gbDoiMatKhau.Visible = true;
            btnDoiMatKhau.Enabled = false;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (LoaiTaiKhoan == "SV")
                this.taikhoanTableAdapter.FillByMaSV(this.qlsvDataSet.TAIKHOAN, MaNguoiDung);
            else
                this.taikhoanTableAdapter.FillByMaGV(this.qlsvDataSet.TAIKHOAN, MaNguoiDung);
            String TenDangNhap = qlsvDataSet.TAIKHOAN.Rows[0]["TenDangNhap"].ToString();

            if (txtMatKhauHienTai.Text == "" || txtMatKhauMoi.Text == "" || txtNhapLaiMatKhauMoi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtMatKhauHienTai.Text != qlsvDataSet.TAIKHOAN.Rows[0]["MatKhau"].ToString())
            {
                MessageBox.Show("Mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtMatKhauMoi.Text != txtNhapLaiMatKhauMoi.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtMatKhauMoi.Text == txtMatKhauHienTai.Text)
            {
                MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                taikhoanTableAdapter.UpdateMatKhau(txtMatKhauMoi.Text, TenDangNhap);
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            gbDoiMatKhau.Visible = false;
            if (LoaiTaiKhoan == "SV")
                this.taikhoanTableAdapter.FillByMaSV(this.qlsvDataSet.TAIKHOAN, MaNguoiDung);
            else
                this.taikhoanTableAdapter.FillByMaGV(this.qlsvDataSet.TAIKHOAN, MaNguoiDung);
            txtMatKhau.Text = qlsvDataSet.TAIKHOAN.Rows[0]["MatKhau"].ToString();
            btnDoiMatKhau.Enabled = true;

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            gbDoiMatKhau.Visible = false;
            btnDoiMatKhau.Enabled = true;
        }
    }
}
