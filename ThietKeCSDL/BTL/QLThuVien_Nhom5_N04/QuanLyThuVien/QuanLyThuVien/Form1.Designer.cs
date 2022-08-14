
namespace QuanLyThuVien
{
    partial class Form1
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoTT6 = new System.Windows.Forms.RadioButton();
            this.rdoTT5 = new System.Windows.Forms.RadioButton();
            this.rdoTT4 = new System.Windows.Forms.RadioButton();
            this.rdoTT2 = new System.Windows.Forms.RadioButton();
            this.rdoTT1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoHam5 = new System.Windows.Forms.RadioButton();
            this.rdoHam4 = new System.Windows.Forms.RadioButton();
            this.rdoHam3 = new System.Windows.Forms.RadioButton();
            this.rdoHam2 = new System.Windows.Forms.RadioButton();
            this.rdoHam1 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdoView10 = new System.Windows.Forms.RadioButton();
            this.rdoView1 = new System.Windows.Forms.RadioButton();
            this.rdoView9 = new System.Windows.Forms.RadioButton();
            this.rdoView8 = new System.Windows.Forms.RadioButton();
            this.rdoView4 = new System.Windows.Forms.RadioButton();
            this.rdoView7 = new System.Windows.Forms.RadioButton();
            this.rdoView6 = new System.Windows.Forms.RadioButton();
            this.rdoView5 = new System.Windows.Forms.RadioButton();
            this.rdoView3 = new System.Windows.Forms.RadioButton();
            this.rdoView2 = new System.Windows.Forms.RadioButton();
            this.rdoDocGia = new System.Windows.Forms.RadioButton();
            this.rdoTaiLieu = new System.Windows.Forms.RadioButton();
            this.rdoHam7 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(445, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ THƯ VIỆN";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(0, 25);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 62;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.Size = new System.Drawing.Size(1247, 372);
            this.dgvData.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvData);
            this.groupBox1.Location = new System.Drawing.Point(12, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1247, 397);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoTaiLieu);
            this.groupBox2.Controls.Add(this.rdoDocGia);
            this.groupBox2.Controls.Add(this.rdoTT6);
            this.groupBox2.Controls.Add(this.rdoTT5);
            this.groupBox2.Controls.Add(this.rdoTT4);
            this.groupBox2.Controls.Add(this.rdoTT2);
            this.groupBox2.Controls.Add(this.rdoTT1);
            this.groupBox2.Location = new System.Drawing.Point(12, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 191);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thủ tục";
            // 
            // rdoTT6
            // 
            this.rdoTT6.AutoSize = true;
            this.rdoTT6.Location = new System.Drawing.Point(40, 156);
            this.rdoTT6.Name = "rdoTT6";
            this.rdoTT6.Size = new System.Drawing.Size(88, 24);
            this.rdoTT6.TabIndex = 1;
            this.rdoTT6.TabStop = true;
            this.rdoTT6.Text = "SuaDG";
            this.rdoTT6.UseVisualStyleBackColor = true;
            this.rdoTT6.CheckedChanged += new System.EventHandler(this.rdo6_CheckedChanged_1);
            // 
            // rdoTT5
            // 
            this.rdoTT5.AutoSize = true;
            this.rdoTT5.Location = new System.Drawing.Point(40, 117);
            this.rdoTT5.Name = "rdoTT5";
            this.rdoTT5.Size = new System.Drawing.Size(88, 24);
            this.rdoTT5.TabIndex = 2;
            this.rdoTT5.TabStop = true;
            this.rdoTT5.Text = "XoaDG";
            this.rdoTT5.UseVisualStyleBackColor = true;
            this.rdoTT5.CheckedChanged += new System.EventHandler(this.rdoTT5_CheckedChanged_1);
            // 
            // rdoTT4
            // 
            this.rdoTT4.AutoSize = true;
            this.rdoTT4.Location = new System.Drawing.Point(195, 117);
            this.rdoTT4.Name = "rdoTT4";
            this.rdoTT4.Size = new System.Drawing.Size(81, 24);
            this.rdoTT4.TabIndex = 3;
            this.rdoTT4.TabStop = true;
            this.rdoTT4.Text = "XoaTL";
            this.rdoTT4.UseVisualStyleBackColor = true;
            this.rdoTT4.CheckedChanged += new System.EventHandler(this.rdoTT4_CheckedChanged_1);
            // 
            // rdoTT2
            // 
            this.rdoTT2.AutoSize = true;
            this.rdoTT2.Location = new System.Drawing.Point(195, 77);
            this.rdoTT2.Name = "rdoTT2";
            this.rdoTT2.Size = new System.Drawing.Size(92, 24);
            this.rdoTT2.TabIndex = 0;
            this.rdoTT2.TabStop = true;
            this.rdoTT2.Text = "ThemTL";
            this.rdoTT2.UseVisualStyleBackColor = true;
            this.rdoTT2.CheckedChanged += new System.EventHandler(this.rdoTT2_CheckedChanged_1);
            // 
            // rdoTT1
            // 
            this.rdoTT1.AutoSize = true;
            this.rdoTT1.Location = new System.Drawing.Point(40, 77);
            this.rdoTT1.Name = "rdoTT1";
            this.rdoTT1.Size = new System.Drawing.Size(99, 24);
            this.rdoTT1.TabIndex = 0;
            this.rdoTT1.TabStop = true;
            this.rdoTT1.Text = "ThemDG";
            this.rdoTT1.UseVisualStyleBackColor = true;
            this.rdoTT1.CheckedChanged += new System.EventHandler(this.rdoTT1_CheckedChanged_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoHam7);
            this.groupBox3.Controls.Add(this.rdoHam5);
            this.groupBox3.Controls.Add(this.rdoHam4);
            this.groupBox3.Controls.Add(this.rdoHam3);
            this.groupBox3.Controls.Add(this.rdoHam1);
            this.groupBox3.Controls.Add(this.rdoHam2);
            this.groupBox3.Location = new System.Drawing.Point(353, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(394, 191);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hàm";
            // 
            // rdoHam5
            // 
            this.rdoHam5.AutoSize = true;
            this.rdoHam5.Location = new System.Drawing.Point(218, 36);
            this.rdoHam5.Name = "rdoHam5";
            this.rdoHam5.Size = new System.Drawing.Size(134, 24);
            this.rdoHam5.TabIndex = 5;
            this.rdoHam5.TabStop = true;
            this.rdoHam5.Text = "TraSachTruoc";
            this.rdoHam5.UseVisualStyleBackColor = true;
            this.rdoHam5.CheckedChanged += new System.EventHandler(this.rdoHam5_CheckedChanged);
            // 
            // rdoHam4
            // 
            this.rdoHam4.AutoSize = true;
            this.rdoHam4.Location = new System.Drawing.Point(36, 115);
            this.rdoHam4.Name = "rdoHam4";
            this.rdoHam4.Size = new System.Drawing.Size(103, 24);
            this.rdoHam4.TabIndex = 6;
            this.rdoHam4.TabStop = true;
            this.rdoHam4.Text = "TongPhat";
            this.rdoHam4.UseVisualStyleBackColor = true;
            this.rdoHam4.CheckedChanged += new System.EventHandler(this.rdoHam4_CheckedChanged);
            // 
            // rdoHam3
            // 
            this.rdoHam3.AutoSize = true;
            this.rdoHam3.Location = new System.Drawing.Point(36, 76);
            this.rdoHam3.Name = "rdoHam3";
            this.rdoHam3.Size = new System.Drawing.Size(118, 24);
            this.rdoHam3.TabIndex = 1;
            this.rdoHam3.TabStop = true;
            this.rdoHam3.Text = "HT_ThuThu";
            this.rdoHam3.UseVisualStyleBackColor = true;
            this.rdoHam3.CheckedChanged += new System.EventHandler(this.rdoHam3_CheckedChanged);
            // 
            // rdoHam2
            // 
            this.rdoHam2.AutoSize = true;
            this.rdoHam2.Location = new System.Drawing.Point(36, 36);
            this.rdoHam2.Name = "rdoHam2";
            this.rdoHam2.Size = new System.Drawing.Size(169, 24);
            this.rdoHam2.TabIndex = 2;
            this.rdoHam2.TabStop = true;
            this.rdoHam2.Text = "DS_TLMuonThang";
            this.rdoHam2.UseVisualStyleBackColor = true;
            this.rdoHam2.CheckedChanged += new System.EventHandler(this.rdoHam2_CheckedChanged);
            // 
            // rdoHam1
            // 
            this.rdoHam1.AutoSize = true;
            this.rdoHam1.Location = new System.Drawing.Point(218, 75);
            this.rdoHam1.Name = "rdoHam1";
            this.rdoHam1.Size = new System.Drawing.Size(77, 24);
            this.rdoHam1.TabIndex = 3;
            this.rdoHam1.TabStop = true;
            this.rdoHam1.Text = "TimTL";
            this.rdoHam1.UseVisualStyleBackColor = true;
            this.rdoHam1.CheckedChanged += new System.EventHandler(this.rdoHam1_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdoView10);
            this.groupBox4.Controls.Add(this.rdoView1);
            this.groupBox4.Controls.Add(this.rdoView9);
            this.groupBox4.Controls.Add(this.rdoView8);
            this.groupBox4.Controls.Add(this.rdoView4);
            this.groupBox4.Controls.Add(this.rdoView7);
            this.groupBox4.Controls.Add(this.rdoView6);
            this.groupBox4.Controls.Add(this.rdoView5);
            this.groupBox4.Controls.Add(this.rdoView3);
            this.groupBox4.Controls.Add(this.rdoView2);
            this.groupBox4.Location = new System.Drawing.Point(761, 89);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(498, 191);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "View";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // rdoView10
            // 
            this.rdoView10.AutoSize = true;
            this.rdoView10.Location = new System.Drawing.Point(261, 154);
            this.rdoView10.Name = "rdoView10";
            this.rdoView10.Size = new System.Drawing.Size(188, 24);
            this.rdoView10.TabIndex = 11;
            this.rdoView10.TabStop = true;
            this.rdoView10.Text = "TiengViet_NuocNgoai";
            this.rdoView10.UseVisualStyleBackColor = true;
            this.rdoView10.CheckedChanged += new System.EventHandler(this.rdoView10_CheckedChanged);
            // 
            // rdoView1
            // 
            this.rdoView1.AutoSize = true;
            this.rdoView1.Location = new System.Drawing.Point(29, 36);
            this.rdoView1.Name = "rdoView1";
            this.rdoView1.Size = new System.Drawing.Size(120, 24);
            this.rdoView1.TabIndex = 10;
            this.rdoView1.TabStop = true;
            this.rdoView1.Text = "DS_ThuThu";
            this.rdoView1.UseVisualStyleBackColor = true;
            this.rdoView1.CheckedChanged += new System.EventHandler(this.rdoView1_CheckedChanged);
            // 
            // rdoView9
            // 
            this.rdoView9.AutoSize = true;
            this.rdoView9.Location = new System.Drawing.Point(261, 124);
            this.rdoView9.Name = "rdoView9";
            this.rdoView9.Size = new System.Drawing.Size(130, 24);
            this.rdoView9.TabIndex = 9;
            this.rdoView9.TabStop = true;
            this.rdoView9.Text = "TLDuocMuon";
            this.rdoView9.UseVisualStyleBackColor = true;
            this.rdoView9.CheckedChanged += new System.EventHandler(this.rdoView9_CheckedChanged);
            // 
            // rdoView8
            // 
            this.rdoView8.AutoSize = true;
            this.rdoView8.Location = new System.Drawing.Point(261, 94);
            this.rdoView8.Name = "rdoView8";
            this.rdoView8.Size = new System.Drawing.Size(167, 24);
            this.rdoView8.TabIndex = 8;
            this.rdoView8.TabStop = true;
            this.rdoView8.Text = "SLTGCuaMoiKhoa";
            this.rdoView8.UseVisualStyleBackColor = true;
            this.rdoView8.CheckedChanged += new System.EventHandler(this.rdoView8_CheckedChanged);
            // 
            // rdoView4
            // 
            this.rdoView4.AutoSize = true;
            this.rdoView4.Location = new System.Drawing.Point(29, 126);
            this.rdoView4.Name = "rdoView4";
            this.rdoView4.Size = new System.Drawing.Size(199, 24);
            this.rdoView4.TabIndex = 7;
            this.rdoView4.Text = "DS_TLMuonNhieuNhat";
            this.rdoView4.UseVisualStyleBackColor = true;
            this.rdoView4.CheckedChanged += new System.EventHandler(this.rdoView4_CheckedChanged);
            // 
            // rdoView7
            // 
            this.rdoView7.AutoSize = true;
            this.rdoView7.Location = new System.Drawing.Point(261, 64);
            this.rdoView7.Name = "rdoView7";
            this.rdoView7.Size = new System.Drawing.Size(162, 24);
            this.rdoView7.TabIndex = 4;
            this.rdoView7.TabStop = true;
            this.rdoView7.Text = "DS_TLNuocNgoai";
            this.rdoView7.UseVisualStyleBackColor = true;
            this.rdoView7.CheckedChanged += new System.EventHandler(this.rdoView7_CheckedChanged);
            // 
            // rdoView6
            // 
            this.rdoView6.AutoSize = true;
            this.rdoView6.Location = new System.Drawing.Point(261, 36);
            this.rdoView6.Name = "rdoView6";
            this.rdoView6.Size = new System.Drawing.Size(204, 24);
            this.rdoView6.TabIndex = 5;
            this.rdoView6.TabStop = true;
            this.rdoView6.Text = "SLPhieuMuonMoiThang";
            this.rdoView6.UseVisualStyleBackColor = true;
            this.rdoView6.CheckedChanged += new System.EventHandler(this.rdoView6_CheckedChanged);
            // 
            // rdoView5
            // 
            this.rdoView5.AutoSize = true;
            this.rdoView5.Location = new System.Drawing.Point(29, 156);
            this.rdoView5.Name = "rdoView5";
            this.rdoView5.Size = new System.Drawing.Size(144, 24);
            this.rdoView5.TabIndex = 6;
            this.rdoView5.TabStop = true;
            this.rdoView5.Text = "DS_TLPhoBien";
            this.rdoView5.UseVisualStyleBackColor = true;
            this.rdoView5.CheckedChanged += new System.EventHandler(this.rdoView5_CheckedChanged);
            // 
            // rdoView3
            // 
            this.rdoView3.AutoSize = true;
            this.rdoView3.Location = new System.Drawing.Point(29, 96);
            this.rdoView3.Name = "rdoView3";
            this.rdoView3.Size = new System.Drawing.Size(220, 24);
            this.rdoView3.TabIndex = 1;
            this.rdoView3.TabStop = true;
            this.rdoView3.Text = "DS_DocGiaChuaNopPhat";
            this.rdoView3.UseVisualStyleBackColor = true;
            this.rdoView3.CheckedChanged += new System.EventHandler(this.rdoView3_CheckedChanged);
            // 
            // rdoView2
            // 
            this.rdoView2.AutoSize = true;
            this.rdoView2.Location = new System.Drawing.Point(28, 66);
            this.rdoView2.Name = "rdoView2";
            this.rdoView2.Size = new System.Drawing.Size(167, 24);
            this.rdoView2.TabIndex = 2;
            this.rdoView2.TabStop = true;
            this.rdoView2.Text = "DS_DocGiaBiPhat";
            this.rdoView2.UseVisualStyleBackColor = true;
            this.rdoView2.CheckedChanged += new System.EventHandler(this.rdoView2_CheckedChanged);
            // 
            // rdoDocGia
            // 
            this.rdoDocGia.AutoSize = true;
            this.rdoDocGia.Location = new System.Drawing.Point(40, 36);
            this.rdoDocGia.Name = "rdoDocGia";
            this.rdoDocGia.Size = new System.Drawing.Size(88, 24);
            this.rdoDocGia.TabIndex = 7;
            this.rdoDocGia.TabStop = true;
            this.rdoDocGia.Text = "DocGia";
            this.rdoDocGia.UseVisualStyleBackColor = true;
            this.rdoDocGia.CheckedChanged += new System.EventHandler(this.rdoDocGia_CheckedChanged);
            // 
            // rdoTaiLieu
            // 
            this.rdoTaiLieu.AutoSize = true;
            this.rdoTaiLieu.Location = new System.Drawing.Point(195, 36);
            this.rdoTaiLieu.Name = "rdoTaiLieu";
            this.rdoTaiLieu.Size = new System.Drawing.Size(85, 24);
            this.rdoTaiLieu.TabIndex = 7;
            this.rdoTaiLieu.TabStop = true;
            this.rdoTaiLieu.Text = "TaiLieu";
            this.rdoTaiLieu.UseVisualStyleBackColor = true;
            this.rdoTaiLieu.CheckedChanged += new System.EventHandler(this.rdoTaiLieu_CheckedChanged);
            // 
            // rdoHam7
            // 
            this.rdoHam7.AutoSize = true;
            this.rdoHam7.Location = new System.Drawing.Point(218, 115);
            this.rdoHam7.Name = "rdoHam7";
            this.rdoHam7.Size = new System.Drawing.Size(106, 24);
            this.rdoHam7.TabIndex = 7;
            this.rdoHam7.TabStop = true;
            this.rdoHam7.Text = "DS_Muon";
            this.rdoHam7.UseVisualStyleBackColor = true;
            this.rdoHam7.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1268, 695);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thư viện";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoTT6;
        private System.Windows.Forms.RadioButton rdoTT5;
        private System.Windows.Forms.RadioButton rdoTT4;
        private System.Windows.Forms.RadioButton rdoTT2;
        private System.Windows.Forms.RadioButton rdoTT1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoHam5;
        private System.Windows.Forms.RadioButton rdoHam4;
        private System.Windows.Forms.RadioButton rdoHam3;
        private System.Windows.Forms.RadioButton rdoHam2;
        private System.Windows.Forms.RadioButton rdoHam1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdoView8;
        private System.Windows.Forms.RadioButton rdoView4;
        private System.Windows.Forms.RadioButton rdoView7;
        private System.Windows.Forms.RadioButton rdoView6;
        private System.Windows.Forms.RadioButton rdoView5;
        private System.Windows.Forms.RadioButton rdoView3;
        private System.Windows.Forms.RadioButton rdoView2;
        private System.Windows.Forms.RadioButton rdoView9;
        private System.Windows.Forms.RadioButton rdoView1;
        private System.Windows.Forms.RadioButton rdoView10;
        private System.Windows.Forms.RadioButton rdoDocGia;
        private System.Windows.Forms.RadioButton rdoTaiLieu;
        private System.Windows.Forms.RadioButton rdoHam7;
    }
}

