
namespace MuonSach
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTinhTrangSach = new System.Windows.Forms.TextBox();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaMuon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPhieuMuon = new System.Windows.Forms.DataGridView();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoLuongMuon = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.qLGiaoTrinhDataSet = new MuonSach.QLGiaoTrinhDataSet();
            this.phieuMuonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuMuonTableAdapter = new MuonSach.QLGiaoTrinhDataSetTableAdapters.PhieuMuonTableAdapter();
            this.qLGiaoTrinhDataSet1 = new MuonSach.QLGiaoTrinhDataSet1();
            this.phieuMuonBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.phieuMuonTableAdapter1 = new MuonSach.QLGiaoTrinhDataSet1TableAdapters.PhieuMuonTableAdapter();
            this.maPhieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDocGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maGTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayMuonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayPhaiTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trinhTrangMuonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrangThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLGiaoTrinhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuMuonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLGiaoTrinhDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuMuonBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtSoLuongMuon);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtTinhTrangSach);
            this.panel1.Controls.Add(this.txtMaDG);
            this.panel1.Controls.Add(this.txtMaSach);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtpNgayTra);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtpNgayMuon);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtMaMuon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 208);
            this.panel1.TabIndex = 0;
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ImageKey = "(none)";
            this.btnXoa.Location = new System.Drawing.Point(629, 146);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(50, 46);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(554, 146);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(50, 46);
            this.btnSua.TabIndex = 10;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(481, 146);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(50, 46);
            this.btnThem.TabIndex = 10;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTinhTrangSach
            // 
            this.txtTinhTrangSach.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTinhTrangSach.Location = new System.Drawing.Point(172, 82);
            this.txtTinhTrangSach.Multiline = true;
            this.txtTinhTrangSach.Name = "txtTinhTrangSach";
            this.txtTinhTrangSach.Size = new System.Drawing.Size(147, 43);
            this.txtTinhTrangSach.TabIndex = 25;
            // 
            // txtMaDG
            // 
            this.txtMaDG.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaDG.Location = new System.Drawing.Point(483, 12);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Size = new System.Drawing.Size(151, 22);
            this.txtMaDG.TabIndex = 17;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaSach.Location = new System.Drawing.Point(167, 44);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(151, 22);
            this.txtMaSach.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(337, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mã độc giả :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(21, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mã Sách:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(21, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 21);
            this.label7.TabIndex = 24;
            this.label7.Text = "Tình trạng sách:";
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTra.Location = new System.Drawing.Point(483, 96);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(147, 29);
            this.dtpNgayTra.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(334, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ngày phải trả :";
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayMuon.Location = new System.Drawing.Point(483, 48);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(147, 29);
            this.dtpNgayMuon.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(334, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ngày mượn :";
            // 
            // txtMaMuon
            // 
            this.txtMaMuon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaMuon.Location = new System.Drawing.Point(167, 11);
            this.txtMaMuon.Name = "txtMaMuon";
            this.txtMaMuon.Size = new System.Drawing.Size(151, 22);
            this.txtMaMuon.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(21, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã phiếu mượn:";
            // 
            // dgvPhieuMuon
            // 
            this.dgvPhieuMuon.AutoGenerateColumns = false;
            this.dgvPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhieuDataGridViewTextBoxColumn,
            this.maDocGiaDataGridViewTextBoxColumn,
            this.maGTDataGridViewTextBoxColumn,
            this.SoLuong,
            this.ngayMuonDataGridViewTextBoxColumn,
            this.ngayPhaiTraDataGridViewTextBoxColumn,
            this.trinhTrangMuonDataGridViewTextBoxColumn,
            this.TinhTrangThe});
            this.dgvPhieuMuon.DataSource = this.phieuMuonBindingSource1;
            this.dgvPhieuMuon.Location = new System.Drawing.Point(36, 246);
            this.dgvPhieuMuon.Name = "dgvPhieuMuon";
            this.dgvPhieuMuon.Size = new System.Drawing.Size(723, 224);
            this.dgvPhieuMuon.TabIndex = 1;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioButton2.Location = new System.Drawing.Point(281, 171);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(98, 25);
            this.radioButton2.TabIndex = 31;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Thẻ khóa";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioButton1.Location = new System.Drawing.Point(184, 169);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(86, 25);
            this.radioButton1.TabIndex = 30;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Thẻ mở";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(21, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = "Tình trạng thẻ :";
            // 
            // txtSoLuongMuon
            // 
            this.txtSoLuongMuon.Location = new System.Drawing.Point(175, 135);
            this.txtSoLuongMuon.Name = "txtSoLuongMuon";
            this.txtSoLuongMuon.Size = new System.Drawing.Size(143, 20);
            this.txtSoLuongMuon.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(21, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 21);
            this.label8.TabIndex = 27;
            this.label8.Text = "Số Lượng Mượn :";
            // 
            // qLGiaoTrinhDataSet
            // 
            this.qLGiaoTrinhDataSet.DataSetName = "QLGiaoTrinhDataSet";
            this.qLGiaoTrinhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phieuMuonBindingSource
            // 
            this.phieuMuonBindingSource.DataMember = "PhieuMuon";
            this.phieuMuonBindingSource.DataSource = this.qLGiaoTrinhDataSet;
            // 
            // phieuMuonTableAdapter
            // 
            this.phieuMuonTableAdapter.ClearBeforeFill = true;
            // 
            // qLGiaoTrinhDataSet1
            // 
            this.qLGiaoTrinhDataSet1.DataSetName = "QLGiaoTrinhDataSet1";
            this.qLGiaoTrinhDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phieuMuonBindingSource1
            // 
            this.phieuMuonBindingSource1.DataMember = "PhieuMuon";
            this.phieuMuonBindingSource1.DataSource = this.qLGiaoTrinhDataSet1;
            // 
            // phieuMuonTableAdapter1
            // 
            this.phieuMuonTableAdapter1.ClearBeforeFill = true;
            // 
            // maPhieuDataGridViewTextBoxColumn
            // 
            this.maPhieuDataGridViewTextBoxColumn.DataPropertyName = "MaPhieu";
            this.maPhieuDataGridViewTextBoxColumn.HeaderText = "MaPhieu";
            this.maPhieuDataGridViewTextBoxColumn.Name = "maPhieuDataGridViewTextBoxColumn";
            this.maPhieuDataGridViewTextBoxColumn.Width = 80;
            // 
            // maDocGiaDataGridViewTextBoxColumn
            // 
            this.maDocGiaDataGridViewTextBoxColumn.DataPropertyName = "MaDocGia";
            this.maDocGiaDataGridViewTextBoxColumn.HeaderText = "MaDocGia";
            this.maDocGiaDataGridViewTextBoxColumn.Name = "maDocGiaDataGridViewTextBoxColumn";
            this.maDocGiaDataGridViewTextBoxColumn.Width = 80;
            // 
            // maGTDataGridViewTextBoxColumn
            // 
            this.maGTDataGridViewTextBoxColumn.DataPropertyName = "MaGT";
            this.maGTDataGridViewTextBoxColumn.HeaderText = "MaGT";
            this.maGTDataGridViewTextBoxColumn.Name = "maGTDataGridViewTextBoxColumn";
            this.maGTDataGridViewTextBoxColumn.Width = 60;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 60;
            // 
            // ngayMuonDataGridViewTextBoxColumn
            // 
            this.ngayMuonDataGridViewTextBoxColumn.DataPropertyName = "NgayMuon";
            this.ngayMuonDataGridViewTextBoxColumn.HeaderText = "NgayMuon";
            this.ngayMuonDataGridViewTextBoxColumn.Name = "ngayMuonDataGridViewTextBoxColumn";
            // 
            // ngayPhaiTraDataGridViewTextBoxColumn
            // 
            this.ngayPhaiTraDataGridViewTextBoxColumn.DataPropertyName = "NgayPhaiTra";
            this.ngayPhaiTraDataGridViewTextBoxColumn.HeaderText = "NgayPhaiTra";
            this.ngayPhaiTraDataGridViewTextBoxColumn.Name = "ngayPhaiTraDataGridViewTextBoxColumn";
            // 
            // trinhTrangMuonDataGridViewTextBoxColumn
            // 
            this.trinhTrangMuonDataGridViewTextBoxColumn.DataPropertyName = "TrinhTrangMuon";
            this.trinhTrangMuonDataGridViewTextBoxColumn.HeaderText = "TrinhTrangMuon";
            this.trinhTrangMuonDataGridViewTextBoxColumn.Name = "trinhTrangMuonDataGridViewTextBoxColumn";
            // 
            // TinhTrangThe
            // 
            this.TinhTrangThe.DataPropertyName = "TinhTrangThe";
            this.TinhTrangThe.HeaderText = "TinhTrangThe";
            this.TinhTrangThe.Name = "TinhTrangThe";
            // 
            // FormPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(786, 494);
            this.Controls.Add(this.dgvPhieuMuon);
            this.Controls.Add(this.panel1);
            this.Name = "FormPhieuMuon";
            this.Text = "FormPhieuMuon";
            this.Load += new System.EventHandler(this.FormPhieuMuon_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLGiaoTrinhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuMuonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLGiaoTrinhDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuMuonBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPhieuMuon;
        private System.Windows.Forms.TextBox txtTinhTrangSach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaMuon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtSoLuongMuon;
        private System.Windows.Forms.Label label8;
        private QLGiaoTrinhDataSet qLGiaoTrinhDataSet;
        private System.Windows.Forms.BindingSource phieuMuonBindingSource;
        private QLGiaoTrinhDataSetTableAdapters.PhieuMuonTableAdapter phieuMuonTableAdapter;
        private QLGiaoTrinhDataSet1 qLGiaoTrinhDataSet1;
        private System.Windows.Forms.BindingSource phieuMuonBindingSource1;
        private QLGiaoTrinhDataSet1TableAdapters.PhieuMuonTableAdapter phieuMuonTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDocGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayMuonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayPhaiTraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trinhTrangMuonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrangThe;
    }
}