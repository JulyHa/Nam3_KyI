
namespace ChuaChoTrang
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MaNV = new System.Windows.Forms.TextBox();
            this.TenNV = new System.Windows.Forms.TextBox();
            this.sdt = new System.Windows.Forms.TextBox();
            this.ml = new System.Windows.Forms.TextBox();
            this.nu = new System.Windows.Forms.RadioButton();
            this.nam = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.them = new System.Windows.Forms.Button();
            this.Sua = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.cv = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(192, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh muc nhan vien";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ma NV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ten NV";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cv);
            this.groupBox1.Controls.Add(this.nam);
            this.groupBox1.Controls.Add(this.nu);
            this.groupBox1.Controls.Add(this.ml);
            this.groupBox1.Controls.Add(this.sdt);
            this.groupBox1.Controls.Add(this.TenNV);
            this.groupBox1.Controls.Add(this.MaNV);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(26, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 193);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhap thong tin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gioi Tinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "CV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Muc luong";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(381, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "SDT";
            // 
            // MaNV
            // 
            this.MaNV.Location = new System.Drawing.Point(114, 56);
            this.MaNV.Name = "MaNV";
            this.MaNV.Size = new System.Drawing.Size(203, 26);
            this.MaNV.TabIndex = 1;
            // 
            // TenNV
            // 
            this.TenNV.Location = new System.Drawing.Point(114, 100);
            this.TenNV.Name = "TenNV";
            this.TenNV.Size = new System.Drawing.Size(203, 26);
            this.TenNV.TabIndex = 1;
            // 
            // sdt
            // 
            this.sdt.Location = new System.Drawing.Point(469, 53);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(203, 26);
            this.sdt.TabIndex = 1;
            this.sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sdt_KeyPress);
            // 
            // ml
            // 
            this.ml.Location = new System.Drawing.Point(469, 146);
            this.ml.Name = "ml";
            this.ml.Size = new System.Drawing.Size(203, 26);
            this.ml.TabIndex = 1;
            this.ml.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sdt_KeyPress);
            // 
            // nu
            // 
            this.nu.AutoSize = true;
            this.nu.Location = new System.Drawing.Point(114, 146);
            this.nu.Name = "nu";
            this.nu.Size = new System.Drawing.Size(52, 24);
            this.nu.TabIndex = 2;
            this.nu.TabStop = true;
            this.nu.Text = "nu";
            this.nu.UseVisualStyleBackColor = true;
            // 
            // nam
            // 
            this.nam.AutoSize = true;
            this.nam.Location = new System.Drawing.Point(203, 149);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(65, 24);
            this.nam.TabIndex = 2;
            this.nam.TabStop = true;
            this.nam.Text = "nam";
            this.nam.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(729, 186);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(54, 478);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(125, 42);
            this.them.TabIndex = 3;
            this.them.Text = "Them";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // Sua
            // 
            this.Sua.Location = new System.Drawing.Point(229, 478);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(125, 42);
            this.Sua.TabIndex = 3;
            this.Sua.Text = "Sua";
            this.Sua.UseVisualStyleBackColor = true;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // Xoa
            // 
            this.Xoa.Location = new System.Drawing.Point(398, 478);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(125, 42);
            this.Xoa.TabIndex = 3;
            this.Xoa.Text = "Xoa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Thoat
            // 
            this.Thoat.Location = new System.Drawing.Point(573, 478);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(125, 42);
            this.Thoat.TabIndex = 3;
            this.Thoat.Text = "Thoat";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // cv
            // 
            this.cv.FormattingEnabled = true;
            this.cv.Location = new System.Drawing.Point(469, 94);
            this.cv.Name = "cv";
            this.cv.Size = new System.Drawing.Size(203, 28);
            this.cv.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 532);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Sua);
            this.Controls.Add(this.them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cv;
        private System.Windows.Forms.RadioButton nam;
        private System.Windows.Forms.RadioButton nu;
        private System.Windows.Forms.TextBox ml;
        private System.Windows.Forms.TextBox sdt;
        private System.Windows.Forms.TextBox TenNV;
        private System.Windows.Forms.TextBox MaNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Thoat;
    }
}

