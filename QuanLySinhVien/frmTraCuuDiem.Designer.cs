namespace AZJ
{
    partial class frmTraCuuDiem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gboFillter = new System.Windows.Forms.GroupBox();
            this.cboFillterHocKy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTraCuuDiem = new System.Windows.Forms.DataGridView();
            this.diemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qlsvDataSet = new AZJ.QLSVDataSet();
            this.monhocTableAdapter = new AZJ.QLSVDataSetTableAdapters.MONHOCTableAdapter();
            this.hockyTableAdapter = new AZJ.QLSVDataSetTableAdapters.HOCKYTableAdapter();
            this.diemTableAdapter = new AZJ.QLSVDataSetTableAdapters.DIEMTableAdapter();
            this.maSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemGiuaKyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemCuoiKyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemTongKetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gboFillter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuuDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsvDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gboFillter
            // 
            this.gboFillter.BackColor = System.Drawing.Color.Transparent;
            this.gboFillter.Controls.Add(this.cboFillterHocKy);
            this.gboFillter.Controls.Add(this.label2);
            this.gboFillter.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboFillter.Location = new System.Drawing.Point(14, 15);
            this.gboFillter.Name = "gboFillter";
            this.gboFillter.Size = new System.Drawing.Size(983, 92);
            this.gboFillter.TabIndex = 129;
            this.gboFillter.TabStop = false;
            this.gboFillter.Text = "Tra Cứu";
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
            // dgvTraCuuDiem
            // 
            this.dgvTraCuuDiem.AllowUserToAddRows = false;
            this.dgvTraCuuDiem.AllowUserToDeleteRows = false;
            this.dgvTraCuuDiem.AllowUserToResizeColumns = false;
            this.dgvTraCuuDiem.AllowUserToResizeRows = false;
            this.dgvTraCuuDiem.AutoGenerateColumns = false;
            this.dgvTraCuuDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTraCuuDiem.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTraCuuDiem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTraCuuDiem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvTraCuuDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraCuuDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSVDataGridViewTextBoxColumn,
            this.TenMH,
            this.TenHK,
            this.diemGiuaKyDataGridViewTextBoxColumn,
            this.diemCuoiKyDataGridViewTextBoxColumn,
            this.diemTongKetDataGridViewTextBoxColumn,
            this.trangThaiDataGridViewTextBoxColumn});
            this.dgvTraCuuDiem.DataSource = this.diemBindingSource;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTraCuuDiem.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvTraCuuDiem.Location = new System.Drawing.Point(12, 113);
            this.dgvTraCuuDiem.MultiSelect = false;
            this.dgvTraCuuDiem.Name = "dgvTraCuuDiem";
            this.dgvTraCuuDiem.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTraCuuDiem.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvTraCuuDiem.RowHeadersVisible = false;
            this.dgvTraCuuDiem.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTraCuuDiem.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvTraCuuDiem.RowTemplate.Height = 24;
            this.dgvTraCuuDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTraCuuDiem.Size = new System.Drawing.Size(983, 560);
            this.dgvTraCuuDiem.TabIndex = 107;
            // 
            // diemBindingSource
            // 
            this.diemBindingSource.DataMember = "DIEM";
            this.diemBindingSource.DataSource = this.qlsvDataSet;
            // 
            // qlsvDataSet
            // 
            this.qlsvDataSet.DataSetName = "QLSVDataSet";
            this.qlsvDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monhocTableAdapter
            // 
            this.monhocTableAdapter.ClearBeforeFill = true;
            // 
            // hockyTableAdapter
            // 
            this.hockyTableAdapter.ClearBeforeFill = true;
            // 
            // diemTableAdapter
            // 
            this.diemTableAdapter.ClearBeforeFill = true;
            // 
            // maSVDataGridViewTextBoxColumn
            // 
            this.maSVDataGridViewTextBoxColumn.DataPropertyName = "MaSV";
            this.maSVDataGridViewTextBoxColumn.HeaderText = "MaSV";
            this.maSVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maSVDataGridViewTextBoxColumn.Name = "maSVDataGridViewTextBoxColumn";
            this.maSVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TenMH
            // 
            this.TenMH.DataPropertyName = "TenMH";
            this.TenMH.HeaderText = "TenMH";
            this.TenMH.MinimumWidth = 6;
            this.TenMH.Name = "TenMH";
            this.TenMH.ReadOnly = true;
            // 
            // TenHK
            // 
            this.TenHK.DataPropertyName = "TenHK";
            this.TenHK.HeaderText = "TenHK";
            this.TenHK.MinimumWidth = 6;
            this.TenHK.Name = "TenHK";
            this.TenHK.ReadOnly = true;
            // 
            // diemGiuaKyDataGridViewTextBoxColumn
            // 
            this.diemGiuaKyDataGridViewTextBoxColumn.DataPropertyName = "DiemGiuaKy";
            this.diemGiuaKyDataGridViewTextBoxColumn.HeaderText = "DiemGiuaKy";
            this.diemGiuaKyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diemGiuaKyDataGridViewTextBoxColumn.Name = "diemGiuaKyDataGridViewTextBoxColumn";
            this.diemGiuaKyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diemCuoiKyDataGridViewTextBoxColumn
            // 
            this.diemCuoiKyDataGridViewTextBoxColumn.DataPropertyName = "DiemCuoiKy";
            this.diemCuoiKyDataGridViewTextBoxColumn.HeaderText = "DiemCuoiKy";
            this.diemCuoiKyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diemCuoiKyDataGridViewTextBoxColumn.Name = "diemCuoiKyDataGridViewTextBoxColumn";
            this.diemCuoiKyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diemTongKetDataGridViewTextBoxColumn
            // 
            this.diemTongKetDataGridViewTextBoxColumn.DataPropertyName = "DiemTongKet";
            this.diemTongKetDataGridViewTextBoxColumn.HeaderText = "DiemTongKet";
            this.diemTongKetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diemTongKetDataGridViewTextBoxColumn.Name = "diemTongKetDataGridViewTextBoxColumn";
            this.diemTongKetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trangThaiDataGridViewTextBoxColumn
            // 
            this.trangThaiDataGridViewTextBoxColumn.DataPropertyName = "TrangThai";
            this.trangThaiDataGridViewTextBoxColumn.HeaderText = "TrangThai";
            this.trangThaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trangThaiDataGridViewTextBoxColumn.Name = "trangThaiDataGridViewTextBoxColumn";
            this.trangThaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmTraCuuDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 685);
            this.Controls.Add(this.gboFillter);
            this.Controls.Add(this.dgvTraCuuDiem);
            this.Name = "frmTraCuuDiem";
            this.Text = "frmTraCuuDiem";
            this.Load += new System.EventHandler(this.frmTraCuuDiem_Load);
            this.gboFillter.ResumeLayout(false);
            this.gboFillter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuuDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsvDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboFillter;
        private System.Windows.Forms.ComboBox cboFillterHocKy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTraCuuDiem;
        private QLSVDataSet qlsvDataSet;
        private QLSVDataSetTableAdapters.MONHOCTableAdapter monhocTableAdapter;
        private QLSVDataSetTableAdapters.HOCKYTableAdapter hockyTableAdapter;
        private System.Windows.Forms.BindingSource diemBindingSource;
        private QLSVDataSetTableAdapters.DIEMTableAdapter diemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemGiuaKyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemCuoiKyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemTongKetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiDataGridViewTextBoxColumn;
    }
}