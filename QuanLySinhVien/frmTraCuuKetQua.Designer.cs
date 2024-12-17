namespace AZJ
{
    partial class frmTraCuuKetQua
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTraCuuKQ = new System.Windows.Forms.DataGridView();
            this.maSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTinChiDatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemTBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xepLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ketquaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qlsvDataSet = new AZJ.QLSVDataSet();
            this.hockyTableAdapter = new AZJ.QLSVDataSetTableAdapters.HOCKYTableAdapter();
            this.ketquaTableAdapter = new AZJ.QLSVDataSetTableAdapters.KETQUATableAdapter();
            this.gboFillter = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboFillterHocKy = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuuKQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketquaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsvDataSet)).BeginInit();
            this.gboFillter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTraCuuKQ
            // 
            this.dgvTraCuuKQ.AllowUserToAddRows = false;
            this.dgvTraCuuKQ.AllowUserToDeleteRows = false;
            this.dgvTraCuuKQ.AllowUserToResizeColumns = false;
            this.dgvTraCuuKQ.AllowUserToResizeRows = false;
            this.dgvTraCuuKQ.AutoGenerateColumns = false;
            this.dgvTraCuuKQ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTraCuuKQ.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTraCuuKQ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTraCuuKQ.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTraCuuKQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraCuuKQ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSVDataGridViewTextBoxColumn,
            this.soTinChiDatDataGridViewTextBoxColumn,
            this.diemTBDataGridViewTextBoxColumn,
            this.xepLoaiDataGridViewTextBoxColumn,
            this.trangThaiDataGridViewTextBoxColumn,
            this.TenHK});
            this.dgvTraCuuKQ.DataSource = this.ketquaBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTraCuuKQ.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTraCuuKQ.Location = new System.Drawing.Point(12, 110);
            this.dgvTraCuuKQ.MultiSelect = false;
            this.dgvTraCuuKQ.Name = "dgvTraCuuKQ";
            this.dgvTraCuuKQ.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTraCuuKQ.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTraCuuKQ.RowHeadersVisible = false;
            this.dgvTraCuuKQ.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTraCuuKQ.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTraCuuKQ.RowTemplate.Height = 24;
            this.dgvTraCuuKQ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTraCuuKQ.Size = new System.Drawing.Size(983, 288);
            this.dgvTraCuuKQ.TabIndex = 130;
            // 
            // maSVDataGridViewTextBoxColumn
            // 
            this.maSVDataGridViewTextBoxColumn.DataPropertyName = "MaSV";
            this.maSVDataGridViewTextBoxColumn.HeaderText = "MaSV";
            this.maSVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maSVDataGridViewTextBoxColumn.Name = "maSVDataGridViewTextBoxColumn";
            this.maSVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soTinChiDatDataGridViewTextBoxColumn
            // 
            this.soTinChiDatDataGridViewTextBoxColumn.DataPropertyName = "SoTinChiDat";
            this.soTinChiDatDataGridViewTextBoxColumn.HeaderText = "SoTinChiDat";
            this.soTinChiDatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soTinChiDatDataGridViewTextBoxColumn.Name = "soTinChiDatDataGridViewTextBoxColumn";
            this.soTinChiDatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diemTBDataGridViewTextBoxColumn
            // 
            this.diemTBDataGridViewTextBoxColumn.DataPropertyName = "DiemTB";
            this.diemTBDataGridViewTextBoxColumn.HeaderText = "DiemTB";
            this.diemTBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diemTBDataGridViewTextBoxColumn.Name = "diemTBDataGridViewTextBoxColumn";
            this.diemTBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // xepLoaiDataGridViewTextBoxColumn
            // 
            this.xepLoaiDataGridViewTextBoxColumn.DataPropertyName = "XepLoai";
            this.xepLoaiDataGridViewTextBoxColumn.HeaderText = "XepLoai";
            this.xepLoaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.xepLoaiDataGridViewTextBoxColumn.Name = "xepLoaiDataGridViewTextBoxColumn";
            this.xepLoaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trangThaiDataGridViewTextBoxColumn
            // 
            this.trangThaiDataGridViewTextBoxColumn.DataPropertyName = "TrangThai";
            this.trangThaiDataGridViewTextBoxColumn.HeaderText = "TrangThai";
            this.trangThaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trangThaiDataGridViewTextBoxColumn.Name = "trangThaiDataGridViewTextBoxColumn";
            this.trangThaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TenHK
            // 
            this.TenHK.DataPropertyName = "TenHK";
            this.TenHK.HeaderText = "TenHK";
            this.TenHK.MinimumWidth = 6;
            this.TenHK.Name = "TenHK";
            this.TenHK.ReadOnly = true;
            // 
            // ketquaBindingSource
            // 
            this.ketquaBindingSource.DataMember = "KETQUA";
            this.ketquaBindingSource.DataSource = this.qlsvDataSet;
            // 
            // qlsvDataSet
            // 
            this.qlsvDataSet.DataSetName = "QLSVDataSet";
            this.qlsvDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hockyTableAdapter
            // 
            this.hockyTableAdapter.ClearBeforeFill = true;
            // 
            // ketquaTableAdapter
            // 
            this.ketquaTableAdapter.ClearBeforeFill = true;
            // 
            // gboFillter
            // 
            this.gboFillter.BackColor = System.Drawing.Color.Transparent;
            this.gboFillter.Controls.Add(this.cboFillterHocKy);
            this.gboFillter.Controls.Add(this.label2);
            this.gboFillter.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboFillter.Location = new System.Drawing.Point(12, 12);
            this.gboFillter.Name = "gboFillter";
            this.gboFillter.Size = new System.Drawing.Size(983, 92);
            this.gboFillter.TabIndex = 131;
            this.gboFillter.TabStop = false;
            this.gboFillter.Text = "Tra Cứu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(417, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Học Kỳ";
            // 
            // cboFillterHocKy
            // 
            this.cboFillterHocKy.BackColor = System.Drawing.SystemColors.Window;
            this.cboFillterHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFillterHocKy.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFillterHocKy.FormattingEnabled = true;
            this.cboFillterHocKy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboFillterHocKy.Location = new System.Drawing.Point(420, 38);
            this.cboFillterHocKy.Name = "cboFillterHocKy";
            this.cboFillterHocKy.Size = new System.Drawing.Size(159, 23);
            this.cboFillterHocKy.TabIndex = 5;
            this.cboFillterHocKy.SelectedIndexChanged += new System.EventHandler(this.cboFillterHocKy_SelectedIndexChanged);
            // 
            // frmTraCuuKetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 685);
            this.Controls.Add(this.gboFillter);
            this.Controls.Add(this.dgvTraCuuKQ);
            this.Name = "frmTraCuuKetQua";
            this.Text = "frmTraCuuKetQua";
            this.Load += new System.EventHandler(this.frmTraCuuKetQua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuuKQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketquaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsvDataSet)).EndInit();
            this.gboFillter.ResumeLayout(false);
            this.gboFillter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTraCuuKQ;
        private QLSVDataSet qlsvDataSet;
        private QLSVDataSetTableAdapters.HOCKYTableAdapter hockyTableAdapter;
        private QLSVDataSetTableAdapters.KETQUATableAdapter ketquaTableAdapter;
        private System.Windows.Forms.BindingSource ketquaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTinChiDatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemTBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xepLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gboFillter;
        private System.Windows.Forms.ComboBox cboFillterHocKy;
        private System.Windows.Forms.Label label2;
    }
}