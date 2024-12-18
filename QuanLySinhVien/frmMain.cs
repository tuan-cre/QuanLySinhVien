using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AZJ
{
    public partial class frmMain : Form
    {
        String MaNguoiDung;
        String LoaiTaiKhoan;
        public frmMain(String MaNguoiDung, String LoaiTaiKhoan)
        {
            InitializeComponent();
            this.MaNguoiDung = MaNguoiDung;
            this.LoaiTaiKhoan = LoaiTaiKhoan;
        }
        private void OpenFormInPanel(Form childForm)
        {
            pnlMain.Controls.Clear();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(childForm);
            pnlMain.Tag = childForm;

            childForm.Show();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (LoaiTaiKhoan == "SV")
            {
                OpenFormInPanel(new frmHome());
                mnuQuanLy.Visible = false;
                lblChucVu.Text = "Sinh Viên";
                picAvatar.Image = Properties.Resources.stdava;
            }
            else if (LoaiTaiKhoan == "GV")
            {
                OpenFormInPanel(new frmHome());
                mnuTaiKhoan.Visible = false;
                mnuGiangVien.Visible = false;
                mnuBoMon.Visible = false;
                mnuKhoa.Visible = false;
                mnuHocKy.Visible = false;
                mnuLop.Visible = false;
                mnuMonHoc.Visible = false;
                mnuKetQua.Visible = false;
                mnuTraCuu.Visible = false;
                lblChucVu.Text = "Giảng Viên";
                picAvatar.Image = Properties.Resources.tchava;
            }
            else
            {
                OpenFormInPanel(new frmHome());
                mnuTraCuu.Visible = false;
                lblChucVu.Text = "Quản Trị Viên";
                picAvatar.Image = Properties.Resources.admava;
            }

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void hồSơToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoaiTaiKhoan == "SV")
                OpenFormInPanel(new frmHoSoSinhVien(MaNguoiDung));
            else
                OpenFormInPanel(new frmHoSoGiaoVien(MaNguoiDung));
        }
        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoaiTaiKhoan == "GV")
                OpenFormInPanel(new frmSinhVien(MaNguoiDung));
            else
                OpenFormInPanel(new frmSinhVien());
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmLop());
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmMonHoc());
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form loginForm = new frmLogin();
            loginForm.Show();
            this.Hide();
        }

        private void điểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmDiem());
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmHoSoTaiKhoan(MaNguoiDung, LoaiTaiKhoan));
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

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.Invalidate();
            else if (this.WindowState == FormWindowState.Normal)
                this.Invalidate();
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmKhoa());
        }

        private void bộMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmBoMon());
        }

        private void tàiKhoảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmTaiKhoan());
        }

        private void kếtQuảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmKetQua());
        }

        private void giảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmGiangVien());
        }

        private void kếtQủaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmTraCuuKetQua(MaNguoiDung));
        }

        private void điểmToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmTraCuuDiem(MaNguoiDung));
        }

        private void họcKỳToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmHocKy());
        }

        private void mnuHome_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmHome());
        }

        private void mnuHuongDan_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmHuongDan());
        }

        private void mnuVeChungToi_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmAbout());
        }
    }
}
