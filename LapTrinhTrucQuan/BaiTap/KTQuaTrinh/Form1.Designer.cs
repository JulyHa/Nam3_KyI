
namespace KTQuaTrinh
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataNV = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.maNV = new System.Windows.Forms.TextBox();
            this.tenNV = new System.Windows.Forms.TextBox();
            this.phong = new System.Windows.Forms.TextBox();
            this.hsl = new System.Windows.Forms.TextBox();
            this.bhtn = new System.Windows.Forms.TextBox();
            this.bhyt = new System.Windows.Forms.TextBox();
            this.bhxh = new System.Windows.Forms.TextBox();
            this.thuclinh = new System.Windows.Forms.TextBox();
            this.hopdong = new System.Windows.Forms.DateTimePicker();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataNV)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(42, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 36);
            this.button2.TabIndex = 0;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(42, 461);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 36);
            this.button3.TabIndex = 0;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(223, 365);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 36);
            this.button4.TabIndex = 0;
            this.button4.Text = "Tìm kiếm";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(223, 414);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 36);
            this.button5.TabIndex = 0;
            this.button5.Text = "Xuất báo cáo";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(223, 461);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(127, 36);
            this.button6.TabIndex = 0;
            this.button6.Text = "Thoát";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày hợp đồng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Hệ số lương";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Bảo hiểm thất nghiệp";
            // 
            // dataNV
            // 
            this.dataNV.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNV.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataNV.Location = new System.Drawing.Point(412, 0);
            this.dataNV.Name = "dataNV";
            this.dataNV.RowHeadersWidth = 62;
            this.dataNV.RowTemplate.Height = 28;
            this.dataNV.Size = new System.Drawing.Size(888, 514);
            this.dataNV.TabIndex = 2;
            this.dataNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNV_CellClick);
            this.dataNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNV_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "BHYT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "BHXH";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Thực lĩnh";
            // 
            // maNV
            // 
            this.maNV.Location = new System.Drawing.Point(135, 23);
            this.maNV.Name = "maNV";
            this.maNV.Size = new System.Drawing.Size(186, 26);
            this.maNV.TabIndex = 4;
            // 
            // tenNV
            // 
            this.tenNV.Location = new System.Drawing.Point(135, 55);
            this.tenNV.Name = "tenNV";
            this.tenNV.Size = new System.Drawing.Size(186, 26);
            this.tenNV.TabIndex = 4;
            // 
            // phong
            // 
            this.phong.Location = new System.Drawing.Point(135, 86);
            this.phong.Name = "phong";
            this.phong.Size = new System.Drawing.Size(186, 26);
            this.phong.TabIndex = 4;
            // 
            // hsl
            // 
            this.hsl.Location = new System.Drawing.Point(135, 169);
            this.hsl.Name = "hsl";
            this.hsl.Size = new System.Drawing.Size(186, 26);
            this.hsl.TabIndex = 4;
            this.hsl.TextChanged += new System.EventHandler(this.hsl_TextChanged);
            // 
            // bhtn
            // 
            this.bhtn.Location = new System.Drawing.Point(179, 206);
            this.bhtn.Name = "bhtn";
            this.bhtn.Size = new System.Drawing.Size(142, 26);
            this.bhtn.TabIndex = 4;
            // 
            // bhyt
            // 
            this.bhyt.Location = new System.Drawing.Point(135, 243);
            this.bhyt.Name = "bhyt";
            this.bhyt.Size = new System.Drawing.Size(186, 26);
            this.bhyt.TabIndex = 4;
            // 
            // bhxh
            // 
            this.bhxh.Location = new System.Drawing.Point(135, 278);
            this.bhxh.Name = "bhxh";
            this.bhxh.Size = new System.Drawing.Size(186, 26);
            this.bhxh.TabIndex = 4;
            // 
            // thuclinh
            // 
            this.thuclinh.Location = new System.Drawing.Point(135, 314);
            this.thuclinh.Name = "thuclinh";
            this.thuclinh.Size = new System.Drawing.Size(186, 26);
            this.thuclinh.TabIndex = 4;
            // 
            // hopdong
            // 
            this.hopdong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hopdong.Location = new System.Drawing.Point(133, 125);
            this.hopdong.Name = "hopdong";
            this.hopdong.Size = new System.Drawing.Size(188, 26);
            this.hopdong.TabIndex = 5;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkLabel1.Location = new System.Drawing.Point(337, 3);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(69, 20);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Làm mới";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 514);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.hopdong);
            this.Controls.Add(this.thuclinh);
            this.Controls.Add(this.bhxh);
            this.Controls.Add(this.bhyt);
            this.Controls.Add(this.bhtn);
            this.Controls.Add(this.hsl);
            this.Controls.Add(this.phong);
            this.Controls.Add(this.tenNV);
            this.Controls.Add(this.maNV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataNV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox maNV;
        private System.Windows.Forms.TextBox tenNV;
        private System.Windows.Forms.TextBox phong;
        private System.Windows.Forms.TextBox hsl;
        private System.Windows.Forms.TextBox bhtn;
        private System.Windows.Forms.TextBox bhyt;
        private System.Windows.Forms.TextBox bhxh;
        private System.Windows.Forms.TextBox thuclinh;
        private System.Windows.Forms.DateTimePicker hopdong;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

