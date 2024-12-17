namespace AZJ
{
    partial class frmHoSoTaiKhoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbThongTinTaiKhoan = new System.Windows.Forms.GroupBox();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtLoaiTaiKhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbDoiMatKhau = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.txtNhapLaiMatKhauMoi = new System.Windows.Forms.TextBox();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.txtMatKhauHienTai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.taikhoanTableAdapter = new AZJ.QLSVDataSetTableAdapters.TAIKHOANTableAdapter();
            this.qlsvDataSet = new AZJ.QLSVDataSet();
            this.gbThongTinTaiKhoan.SuspendLayout();
            this.gbDoiMatKhau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qlsvDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu";
            // 
            // gbThongTinTaiKhoan
            // 
            this.gbThongTinTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.gbThongTinTaiKhoan.Controls.Add(this.btnDoiMatKhau);
            this.gbThongTinTaiKhoan.Controls.Add(this.txtMatKhau);
            this.gbThongTinTaiKhoan.Controls.Add(this.txtTenDangNhap);
            this.gbThongTinTaiKhoan.Controls.Add(this.txtLoaiTaiKhoan);
            this.gbThongTinTaiKhoan.Controls.Add(this.label3);
            this.gbThongTinTaiKhoan.Controls.Add(this.label1);
            this.gbThongTinTaiKhoan.Controls.Add(this.label2);
            this.gbThongTinTaiKhoan.Location = new System.Drawing.Point(200, 67);
            this.gbThongTinTaiKhoan.Name = "gbThongTinTaiKhoan";
            this.gbThongTinTaiKhoan.Size = new System.Drawing.Size(600, 200);
            this.gbThongTinTaiKhoan.TabIndex = 4;
            this.gbThongTinTaiKhoan.TabStop = false;
            this.gbThongTinTaiKhoan.Text = "Thông Tin Tài Khoản";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Location = new System.Drawing.Point(241, 152);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(111, 31);
            this.btnDoiMatKhau.TabIndex = 6;
            this.btnDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Enabled = false;
            this.txtMatKhau.Location = new System.Drawing.Point(212, 113);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.ReadOnly = true;
            this.txtMatKhau.Size = new System.Drawing.Size(286, 22);
            this.txtMatKhau.TabIndex = 5;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Enabled = false;
            this.txtTenDangNhap.Location = new System.Drawing.Point(212, 73);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.ReadOnly = true;
            this.txtTenDangNhap.Size = new System.Drawing.Size(286, 22);
            this.txtTenDangNhap.TabIndex = 4;
            // 
            // txtLoaiTaiKhoan
            // 
            this.txtLoaiTaiKhoan.Enabled = false;
            this.txtLoaiTaiKhoan.Location = new System.Drawing.Point(212, 37);
            this.txtLoaiTaiKhoan.Name = "txtLoaiTaiKhoan";
            this.txtLoaiTaiKhoan.ReadOnly = true;
            this.txtLoaiTaiKhoan.Size = new System.Drawing.Size(286, 22);
            this.txtLoaiTaiKhoan.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại Tài Khoản";
            // 
            // gbDoiMatKhau
            // 
            this.gbDoiMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.gbDoiMatKhau.Controls.Add(this.btnHuy);
            this.gbDoiMatKhau.Controls.Add(this.btnXacNhan);
            this.gbDoiMatKhau.Controls.Add(this.txtNhapLaiMatKhauMoi);
            this.gbDoiMatKhau.Controls.Add(this.txtMatKhauMoi);
            this.gbDoiMatKhau.Controls.Add(this.txtMatKhauHienTai);
            this.gbDoiMatKhau.Controls.Add(this.label4);
            this.gbDoiMatKhau.Controls.Add(this.label5);
            this.gbDoiMatKhau.Controls.Add(this.label6);
            this.gbDoiMatKhau.Location = new System.Drawing.Point(200, 324);
            this.gbDoiMatKhau.Name = "gbDoiMatKhau";
            this.gbDoiMatKhau.Size = new System.Drawing.Size(600, 200);
            this.gbDoiMatKhau.TabIndex = 6;
            this.gbDoiMatKhau.TabStop = false;
            this.gbDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.gbDoiMatKhau.Visible = false;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(358, 151);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(111, 31);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(241, 151);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(111, 31);
            this.btnXacNhan.TabIndex = 7;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // txtNhapLaiMatKhauMoi
            // 
            this.txtNhapLaiMatKhauMoi.Location = new System.Drawing.Point(212, 114);
            this.txtNhapLaiMatKhauMoi.Name = "txtNhapLaiMatKhauMoi";
            this.txtNhapLaiMatKhauMoi.Size = new System.Drawing.Size(286, 22);
            this.txtNhapLaiMatKhauMoi.TabIndex = 5;
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(212, 74);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(286, 22);
            this.txtMatKhauMoi.TabIndex = 4;
            // 
            // txtMatKhauHienTai
            // 
            this.txtMatKhauHienTai.Location = new System.Drawing.Point(212, 38);
            this.txtMatKhauHienTai.Name = "txtMatKhauHienTai";
            this.txtMatKhauHienTai.Size = new System.Drawing.Size(286, 22);
            this.txtMatKhauHienTai.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mật Khẩu Hiện Tại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mật Khẩu Mới";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nhập Lại Mật Khẩu Mới";
            // 
            // taikhoanTableAdapter
            // 
            this.taikhoanTableAdapter.ClearBeforeFill = true;
            // 
            // qlsvDataSet
            // 
            this.qlsvDataSet.DataSetName = "QLSVDataSet";
            this.qlsvDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 685);
            this.Controls.Add(this.gbDoiMatKhau);
            this.Controls.Add(this.gbThongTinTaiKhoan);
            this.Name = "frmTaiKhoan";
            this.Text = "TaiKhoan";
            this.Load += new System.EventHandler(this.TaiKhoanForm_Load);
            this.gbThongTinTaiKhoan.ResumeLayout(false);
            this.gbThongTinTaiKhoan.PerformLayout();
            this.gbDoiMatKhau.ResumeLayout(false);
            this.gbDoiMatKhau.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qlsvDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbThongTinTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtLoaiTaiKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbDoiMatKhau;
        private System.Windows.Forms.TextBox txtNhapLaiMatKhauMoi;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.TextBox txtMatKhauHienTai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXacNhan;
        private QLSVDataSetTableAdapters.TAIKHOANTableAdapter taikhoanTableAdapter;
        private QLSVDataSet qlsvDataSet;
    }
}