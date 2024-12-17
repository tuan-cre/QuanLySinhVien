using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace AZJ
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtUsername.Text = "admin";
            txtPassword.Text = "password";
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.taikhoanTableAdapter.Fill(this.qlsvDataSet.TAIKHOAN);
            bool isValidUser = this.qlsvDataSet.TAIKHOAN.AsEnumerable()
                .Any(row => row["TenDangNhap"].ToString() == txtUsername.Text.Trim() && row["MatKhau"].ToString() == txtPassword.Text.Trim());

            if (isValidUser)
            {
                String MaSV = this.taikhoanTableAdapter.GetDataBy(txtUsername.Text.Trim()).Rows[0]["MaSV"].ToString();
                String MaGV = this.taikhoanTableAdapter.GetDataBy(txtUsername.Text.Trim()).Rows[0]["MaGV"].ToString();
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                String MaNguoiDung = "";
                String LoaiTaiKhoan = "";
                this.taikhoanTableAdapter.FillBy(this.qlsvDataSet.TAIKHOAN, txtUsername.Text);
                if (this.qlsvDataSet.TAIKHOAN.Rows[0]["LoaiTaiKhoan"].ToString() == "Quản Trị Viên")
                {
                    MaNguoiDung = MaGV;
                    LoaiTaiKhoan = "QTV";
                    this.Hide();
                    Form mainForm = new frmMain(MaNguoiDung, LoaiTaiKhoan);
                    mainForm.Show();
                }
                else if (this.qlsvDataSet.TAIKHOAN.Rows[0]["LoaiTaiKhoan"].ToString() == "Giảng Viên")
                {
                    MaNguoiDung = MaGV;
                    LoaiTaiKhoan = "GV";
                    this.Hide();
                    Form mainForm = new frmMain(MaNguoiDung, LoaiTaiKhoan);
                    mainForm.Show();
                }
                else
                {
                    MaNguoiDung = MaSV;
                    LoaiTaiKhoan = "SV";
                    this.Hide();
                    Form mainForm = new frmMain(MaNguoiDung, LoaiTaiKhoan);
                    mainForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
