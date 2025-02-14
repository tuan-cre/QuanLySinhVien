namespace AZJ
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnusMain = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoSo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHSTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBoMon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKetQua = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGiangVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHocKy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTraCuu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTCDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTCKQ = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHuongDan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVeChungToi = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnusMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // mnusMain
            // 
            this.mnusMain.BackColor = System.Drawing.Color.Transparent;
            this.mnusMain.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnusMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.mnuQuanLy,
            this.mnuTraCuu,
            this.trợGiupsToolStripMenuItem});
            this.mnusMain.Location = new System.Drawing.Point(0, 0);
            this.mnusMain.Name = "mnusMain";
            this.mnusMain.Size = new System.Drawing.Size(1014, 29);
            this.mnusMain.TabIndex = 2;
            this.mnusMain.Text = "menuStrip2";
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHome,
            this.mnuHoSo,
            this.mnuHSTaiKhoan,
            this.mnuDangXuat});
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(97, 25);
            this.mnuHeThong.Text = "Hệ Thống";
            // 
            // mnuHome
            // 
            this.mnuHome.Name = "mnuHome";
            this.mnuHome.Size = new System.Drawing.Size(171, 26);
            this.mnuHome.Text = "Trang Chủ";
            this.mnuHome.Click += new System.EventHandler(this.mnuHome_Click);
            // 
            // mnuHoSo
            // 
            this.mnuHoSo.Name = "mnuHoSo";
            this.mnuHoSo.Size = new System.Drawing.Size(171, 26);
            this.mnuHoSo.Text = "Hồ Sơ";
            this.mnuHoSo.Click += new System.EventHandler(this.hồSơToolStripMenuItem_Click);
            // 
            // mnuHSTaiKhoan
            // 
            this.mnuHSTaiKhoan.Name = "mnuHSTaiKhoan";
            this.mnuHSTaiKhoan.Size = new System.Drawing.Size(171, 26);
            this.mnuHSTaiKhoan.Text = "Tài Khoản";
            this.mnuHSTaiKhoan.Click += new System.EventHandler(this.tàiKhoảnToolStripMenuItem_Click);
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(171, 26);
            this.mnuDangXuat.Text = "Đăng Xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // mnuQuanLy
            // 
            this.mnuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSinhVien,
            this.mnuLop,
            this.mnuMonHoc,
            this.mnuDiem,
            this.mnuKhoa,
            this.mnuBoMon,
            this.mnuKetQua,
            this.mnuTaiKhoan,
            this.mnuGiangVien,
            this.mnuHocKy});
            this.mnuQuanLy.Name = "mnuQuanLy";
            this.mnuQuanLy.Size = new System.Drawing.Size(85, 25);
            this.mnuQuanLy.Text = "Quản Lý";
            // 
            // mnuSinhVien
            // 
            this.mnuSinhVien.Name = "mnuSinhVien";
            this.mnuSinhVien.Size = new System.Drawing.Size(170, 26);
            this.mnuSinhVien.Text = "Sinh Viên";
            this.mnuSinhVien.Click += new System.EventHandler(this.sinhViênToolStripMenuItem_Click);
            // 
            // mnuLop
            // 
            this.mnuLop.Name = "mnuLop";
            this.mnuLop.Size = new System.Drawing.Size(170, 26);
            this.mnuLop.Text = "Lớp";
            this.mnuLop.Click += new System.EventHandler(this.lớpToolStripMenuItem_Click);
            // 
            // mnuMonHoc
            // 
            this.mnuMonHoc.Name = "mnuMonHoc";
            this.mnuMonHoc.Size = new System.Drawing.Size(170, 26);
            this.mnuMonHoc.Text = "Môn Học";
            this.mnuMonHoc.Click += new System.EventHandler(this.mônHọcToolStripMenuItem_Click);
            // 
            // mnuDiem
            // 
            this.mnuDiem.Name = "mnuDiem";
            this.mnuDiem.Size = new System.Drawing.Size(170, 26);
            this.mnuDiem.Text = "Điểm";
            this.mnuDiem.Click += new System.EventHandler(this.điểmToolStripMenuItem_Click);
            // 
            // mnuKhoa
            // 
            this.mnuKhoa.Name = "mnuKhoa";
            this.mnuKhoa.Size = new System.Drawing.Size(170, 26);
            this.mnuKhoa.Text = "Khoa";
            this.mnuKhoa.Click += new System.EventHandler(this.khoaToolStripMenuItem_Click);
            // 
            // mnuBoMon
            // 
            this.mnuBoMon.Name = "mnuBoMon";
            this.mnuBoMon.Size = new System.Drawing.Size(170, 26);
            this.mnuBoMon.Text = "Bộ Môn";
            this.mnuBoMon.Click += new System.EventHandler(this.bộMônToolStripMenuItem_Click);
            // 
            // mnuKetQua
            // 
            this.mnuKetQua.Name = "mnuKetQua";
            this.mnuKetQua.Size = new System.Drawing.Size(170, 26);
            this.mnuKetQua.Text = "Kết Quả";
            this.mnuKetQua.Click += new System.EventHandler(this.kếtQuảToolStripMenuItem_Click);
            // 
            // mnuTaiKhoan
            // 
            this.mnuTaiKhoan.Name = "mnuTaiKhoan";
            this.mnuTaiKhoan.Size = new System.Drawing.Size(170, 26);
            this.mnuTaiKhoan.Text = "Tài Khoản";
            this.mnuTaiKhoan.Click += new System.EventHandler(this.tàiKhoảnToolStripMenuItem1_Click);
            // 
            // mnuGiangVien
            // 
            this.mnuGiangVien.Name = "mnuGiangVien";
            this.mnuGiangVien.Size = new System.Drawing.Size(170, 26);
            this.mnuGiangVien.Text = "Giảng Viên";
            this.mnuGiangVien.Click += new System.EventHandler(this.giảngViênToolStripMenuItem_Click);
            // 
            // mnuHocKy
            // 
            this.mnuHocKy.Name = "mnuHocKy";
            this.mnuHocKy.Size = new System.Drawing.Size(170, 26);
            this.mnuHocKy.Text = "Học Kỳ";
            this.mnuHocKy.Click += new System.EventHandler(this.họcKỳToolStripMenuItem_Click);
            // 
            // mnuTraCuu
            // 
            this.mnuTraCuu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTCDiem,
            this.mnuTCKQ,
            this.báoCáoToolStripMenuItem});
            this.mnuTraCuu.Name = "mnuTraCuu";
            this.mnuTraCuu.Size = new System.Drawing.Size(82, 25);
            this.mnuTraCuu.Text = "Tra Cứu";
            // 
            // mnuTCDiem
            // 
            this.mnuTCDiem.Name = "mnuTCDiem";
            this.mnuTCDiem.Size = new System.Drawing.Size(224, 26);
            this.mnuTCDiem.Text = "Điểm";
            this.mnuTCDiem.Click += new System.EventHandler(this.điểmToolStripMenuItem_Click_1);
            // 
            // mnuTCKQ
            // 
            this.mnuTCKQ.Name = "mnuTCKQ";
            this.mnuTCKQ.Size = new System.Drawing.Size(224, 26);
            this.mnuTCKQ.Text = "Kết Quả";
            this.mnuTCKQ.Click += new System.EventHandler(this.kếtQủaToolStripMenuItem_Click);
            // 
            // trợGiupsToolStripMenuItem
            // 
            this.trợGiupsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHuongDan,
            this.mnuVeChungToi});
            this.trợGiupsToolStripMenuItem.Name = "trợGiupsToolStripMenuItem";
            this.trợGiupsToolStripMenuItem.Size = new System.Drawing.Size(88, 25);
            this.trợGiupsToolStripMenuItem.Text = "Trợ Giúp";
            // 
            // mnuHuongDan
            // 
            this.mnuHuongDan.Name = "mnuHuongDan";
            this.mnuHuongDan.Size = new System.Drawing.Size(191, 26);
            this.mnuHuongDan.Text = "Hướng Dẫn";
            this.mnuHuongDan.Click += new System.EventHandler(this.mnuHuongDan_Click);
            // 
            // mnuVeChungToi
            // 
            this.mnuVeChungToi.Name = "mnuVeChungToi";
            this.mnuVeChungToi.Size = new System.Drawing.Size(191, 26);
            this.mnuVeChungToi.Text = "Về Chúng Tôi";
            this.mnuVeChungToi.Click += new System.EventHandler(this.mnuVeChungToi_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMain.Location = new System.Drawing.Point(0, 32);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1014, 721);
            this.pnlMain.TabIndex = 3;
            // 
            // lblChucVu
            // 
            this.lblChucVu.BackColor = System.Drawing.Color.Transparent;
            this.lblChucVu.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.Location = new System.Drawing.Point(845, 5);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(135, 23);
            this.lblChucVu.TabIndex = 4;
            this.lblChucVu.Text = "Quản Trị Viên";
            this.lblChucVu.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.Transparent;
            this.picAvatar.Image = global::AZJ.Properties.Resources.admava;
            this.picAvatar.Location = new System.Drawing.Point(984, 1);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(30, 29);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 5;
            this.picAvatar.TabStop = false;
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.báoCáoToolStripMenuItem.Text = "Báo Cáo";
            this.báoCáoToolStripMenuItem.Click += new System.EventHandler(this.báoCáoToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 753);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.lblChucVu);
            this.Controls.Add(this.mnusMain);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sinh Viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.mnusMain.ResumeLayout(false);
            this.mnusMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnusMain;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuHoSo;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem trợGiupsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolStripMenuItem mnuSinhVien;
        private System.Windows.Forms.ToolStripMenuItem mnuLop;
        private System.Windows.Forms.ToolStripMenuItem mnuMonHoc;
        private System.Windows.Forms.ToolStripMenuItem mnuDiem;
        private System.Windows.Forms.ToolStripMenuItem mnuHuongDan;
        private System.Windows.Forms.ToolStripMenuItem mnuVeChungToi;
        private System.Windows.Forms.ToolStripMenuItem mnuHSTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuKhoa;
        private System.Windows.Forms.ToolStripMenuItem mnuBoMon;
        private System.Windows.Forms.ToolStripMenuItem mnuKetQua;
        private System.Windows.Forms.ToolStripMenuItem mnuTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuGiangVien;
        private System.Windows.Forms.ToolStripMenuItem mnuTraCuu;
        private System.Windows.Forms.ToolStripMenuItem mnuTCDiem;
        private System.Windows.Forms.ToolStripMenuItem mnuTCKQ;
        private System.Windows.Forms.ToolStripMenuItem mnuHocKy;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
    }
}