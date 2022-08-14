
namespace BTL_MuonSach
{
    partial class FormPhieuMuon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhieuMuon));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaHSM = new System.Windows.Forms.TextBox();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.txtMaGT = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvPhieuMuon = new System.Windows.Forms.DataGridView();
            this.phieuMuonBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLGiaoTrinhDataSet1 = new BTL_MuonSach.QLGiaoTrinhDataSet1();
            this.cmbTinhTrangMuon = new System.Windows.Forms.ComboBox();
            this.cmbTinhTrangThe = new System.Windows.Forms.ComboBox();
            this.phieuMuonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLGiaoTrinhDataSet = new BTL_MuonSach.QLGiaoTrinhDataSet1();
            this.phieuMuonTableAdapter = new BTL_MuonSach.QLGiaoTrinhDataSet1TableAdapters.PhieuMuonTableAdapter();
            this.phieuMuonTableAdapter1 = new BTL_MuonSach.QLGiaoTrinhDataSet1TableAdapters.PhieuMuonTableAdapter();
            this.maHSMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maGTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayMuonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayPhaiTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangTheDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trinhTrangMuonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuMuonBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLGiaoTrinhDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuMuonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLGiaoTrinhDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã HSM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã độc giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã GT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số Lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(270, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tình trạng mượn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(270, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tình trạng thẻ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(270, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ngày Phải Trả";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(270, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ngày Mượn";
            // 
            // txtMaHSM
            // 
            this.txtMaHSM.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtMaHSM.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHSM.Location = new System.Drawing.Point(125, 18);
            this.txtMaHSM.Name = "txtMaHSM";
            this.txtMaHSM.Size = new System.Drawing.Size(115, 26);
            this.txtMaHSM.TabIndex = 8;
            // 
            // txtMaDG
            // 
            this.txtMaDG.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtMaDG.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDG.Location = new System.Drawing.Point(125, 56);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Size = new System.Drawing.Size(115, 26);
            this.txtMaDG.TabIndex = 8;
            // 
            // txtMaGT
            // 
            this.txtMaGT.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtMaGT.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGT.Location = new System.Drawing.Point(125, 91);
            this.txtMaGT.Name = "txtMaGT";
            this.txtMaGT.Size = new System.Drawing.Size(115, 26);
            this.txtMaGT.TabIndex = 8;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtSoLuong.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(125, 129);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(115, 26);
            this.txtSoLuong.TabIndex = 8;
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayMuon.Location = new System.Drawing.Point(407, 18);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(134, 26);
            this.dtpNgayMuon.TabIndex = 10;
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTra.Location = new System.Drawing.Point(407, 53);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(134, 26);
            this.dtpNgayTra.TabIndex = 11;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(608, 16);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 28);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.HotPink;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(608, 66);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 28);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Chartreuse;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(608, 123);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 28);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvPhieuMuon
            // 
            this.dgvPhieuMuon.AutoGenerateColumns = false;
            this.dgvPhieuMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuMuon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHSMDataGridViewTextBoxColumn,
            this.MaDG,
            this.maGTDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.ngayMuonDataGridViewTextBoxColumn,
            this.ngayPhaiTraDataGridViewTextBoxColumn,
            this.tinhTrangTheDataGridViewTextBoxColumn,
            this.trinhTrangMuonDataGridViewTextBoxColumn});
            this.dgvPhieuMuon.DataSource = this.phieuMuonBindingSource1;
            this.dgvPhieuMuon.Location = new System.Drawing.Point(36, 191);
            this.dgvPhieuMuon.Name = "dgvPhieuMuon";
            this.dgvPhieuMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuMuon.Size = new System.Drawing.Size(744, 245);
            this.dgvPhieuMuon.TabIndex = 17;
            // 
            // phieuMuonBindingSource1
            // 
            this.phieuMuonBindingSource1.DataMember = "PhieuMuon";
            this.phieuMuonBindingSource1.DataSource = this.qLGiaoTrinhDataSet1;
            // 
            // qLGiaoTrinhDataSet1
            // 
            this.qLGiaoTrinhDataSet1.DataSetName = "QLGiaoTrinhDataSet1";
            this.qLGiaoTrinhDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbTinhTrangMuon
            // 
            this.cmbTinhTrangMuon.FormattingEnabled = true;
            this.cmbTinhTrangMuon.Items.AddRange(new object[] {
            "Đã trả",
            "Đang mượn",
            "Chưa trả"});
            this.cmbTinhTrangMuon.Location = new System.Drawing.Point(409, 128);
            this.cmbTinhTrangMuon.Name = "cmbTinhTrangMuon";
            this.cmbTinhTrangMuon.Size = new System.Drawing.Size(131, 26);
            this.cmbTinhTrangMuon.TabIndex = 18;
            this.cmbTinhTrangMuon.SelectedIndexChanged += new System.EventHandler(this.cmbTinhTrangMuon_SelectedIndexChanged);
            // 
            // cmbTinhTrangThe
            // 
            this.cmbTinhTrangThe.FormattingEnabled = true;
            this.cmbTinhTrangThe.Items.AddRange(new object[] {
            "Thẻ mở",
            "Thẻ đóng"});
            this.cmbTinhTrangThe.Location = new System.Drawing.Point(409, 91);
            this.cmbTinhTrangThe.Name = "cmbTinhTrangThe";
            this.cmbTinhTrangThe.Size = new System.Drawing.Size(131, 26);
            this.cmbTinhTrangThe.TabIndex = 18;
            this.cmbTinhTrangThe.SelectedIndexChanged += new System.EventHandler(this.cmbTinhTrangThe_SelectedIndexChanged);
            // 
            // phieuMuonBindingSource
            // 
            this.phieuMuonBindingSource.DataMember = "PhieuMuon";
            this.phieuMuonBindingSource.DataSource = this.qLGiaoTrinhDataSet;
            // 
            // qLGiaoTrinhDataSet
            // 
            this.qLGiaoTrinhDataSet.DataSetName = "QLGiaoTrinhDataSet";
            this.qLGiaoTrinhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phieuMuonTableAdapter
            // 
            this.phieuMuonTableAdapter.ClearBeforeFill = true;
            // 
            // phieuMuonTableAdapter1
            // 
            this.phieuMuonTableAdapter1.ClearBeforeFill = true;
            // 
            // maHSMDataGridViewTextBoxColumn
            // 
            this.maHSMDataGridViewTextBoxColumn.DataPropertyName = "MaHSM";
            this.maHSMDataGridViewTextBoxColumn.HeaderText = "MaHSM";
            this.maHSMDataGridViewTextBoxColumn.Name = "maHSMDataGridViewTextBoxColumn";
            this.maHSMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MaDG
            // 
            this.MaDG.DataPropertyName = "MaDG";
            this.MaDG.HeaderText = "MaDG";
            this.MaDG.Name = "MaDG";
            // 
            // maGTDataGridViewTextBoxColumn
            // 
            this.maGTDataGridViewTextBoxColumn.DataPropertyName = "MaGT";
            this.maGTDataGridViewTextBoxColumn.HeaderText = "MaGT";
            this.maGTDataGridViewTextBoxColumn.Name = "maGTDataGridViewTextBoxColumn";
            this.maGTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayMuonDataGridViewTextBoxColumn
            // 
            this.ngayMuonDataGridViewTextBoxColumn.DataPropertyName = "NgayMuon";
            this.ngayMuonDataGridViewTextBoxColumn.HeaderText = "NgayMuon";
            this.ngayMuonDataGridViewTextBoxColumn.Name = "ngayMuonDataGridViewTextBoxColumn";
            this.ngayMuonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayPhaiTraDataGridViewTextBoxColumn
            // 
            this.ngayPhaiTraDataGridViewTextBoxColumn.DataPropertyName = "NgayPhaiTra";
            this.ngayPhaiTraDataGridViewTextBoxColumn.HeaderText = "NgayPhaiTra";
            this.ngayPhaiTraDataGridViewTextBoxColumn.Name = "ngayPhaiTraDataGridViewTextBoxColumn";
            this.ngayPhaiTraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tinhTrangTheDataGridViewTextBoxColumn
            // 
            this.tinhTrangTheDataGridViewTextBoxColumn.DataPropertyName = "TinhTrangThe";
            this.tinhTrangTheDataGridViewTextBoxColumn.HeaderText = "TinhTrangThe";
            this.tinhTrangTheDataGridViewTextBoxColumn.Name = "tinhTrangTheDataGridViewTextBoxColumn";
            this.tinhTrangTheDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trinhTrangMuonDataGridViewTextBoxColumn
            // 
            this.trinhTrangMuonDataGridViewTextBoxColumn.DataPropertyName = "TrinhTrangMuon";
            this.trinhTrangMuonDataGridViewTextBoxColumn.HeaderText = "TrinhTrangMuon";
            this.trinhTrangMuonDataGridViewTextBoxColumn.Name = "trinhTrangMuonDataGridViewTextBoxColumn";
            this.trinhTrangMuonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(841, 479);
            this.Controls.Add(this.cmbTinhTrangThe);
            this.Controls.Add(this.cmbTinhTrangMuon);
            this.Controls.Add(this.dgvPhieuMuon);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtpNgayTra);
            this.Controls.Add(this.dtpNgayMuon);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtMaGT);
            this.Controls.Add(this.txtMaDG);
            this.Controls.Add(this.txtMaHSM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPhieuMuon";
            this.Text = "FormPhieuMuon";
            this.Load += new System.EventHandler(this.FormPhieuMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuMuonBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLGiaoTrinhDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuMuonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLGiaoTrinhDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaHSM;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.TextBox txtMaGT;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvPhieuMuon;
        private System.Windows.Forms.ComboBox cmbTinhTrangMuon;
        private QLGiaoTrinhDataSet1 qLGiaoTrinhDataSet;
        private System.Windows.Forms.BindingSource phieuMuonBindingSource;
        private QLGiaoTrinhDataSet1TableAdapters.PhieuMuonTableAdapter phieuMuonTableAdapter;
        private System.Windows.Forms.ComboBox cmbTinhTrangThe;
        private QLGiaoTrinhDataSet1 qLGiaoTrinhDataSet1;
        private System.Windows.Forms.BindingSource phieuMuonBindingSource1;
        private QLGiaoTrinhDataSet1TableAdapters.PhieuMuonTableAdapter phieuMuonTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHSMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayMuonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayPhaiTraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrangTheDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trinhTrangMuonDataGridViewTextBoxColumn;
    }
}