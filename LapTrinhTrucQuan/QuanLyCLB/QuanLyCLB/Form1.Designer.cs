
namespace QuanLyCLB
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Tennuoc = new System.Windows.Forms.TextBox();
            this.sl = new System.Windows.Forms.NumericUpDown();
            this.Tenclb = new System.Windows.Forms.ComboBox();
            this.giave = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataCLB = new System.Windows.Forms.DataGridView();
            this.errtenclb = new System.Windows.Forms.ErrorProvider(this.components);
            this.errtennuoc = new System.Windows.Forms.ErrorProvider(this.components);
            this.errsl = new System.Windows.Forms.ErrorProvider(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.sl)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCLB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errtenclb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errtennuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errsl)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên câu lạc bộ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nước";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá vé";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(43, 404);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 43);
            this.button3.TabIndex = 6;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(252, 404);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 43);
            this.button4.TabIndex = 7;
            this.button4.Text = "Thoát";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Tennuoc
            // 
            this.Tennuoc.Location = new System.Drawing.Point(159, 96);
            this.Tennuoc.Name = "Tennuoc";
            this.Tennuoc.Size = new System.Drawing.Size(214, 26);
            this.Tennuoc.TabIndex = 1;
            // 
            // sl
            // 
            this.sl.Location = new System.Drawing.Point(162, 167);
            this.sl.Name = "sl";
            this.sl.Size = new System.Drawing.Size(70, 26);
            this.sl.TabIndex = 2;
            // 
            // Tenclb
            // 
            this.Tenclb.FormattingEnabled = true;
            this.Tenclb.Location = new System.Drawing.Point(162, 38);
            this.Tenclb.Name = "Tenclb";
            this.Tenclb.Size = new System.Drawing.Size(210, 28);
            this.Tenclb.TabIndex = 0;
            this.Tenclb.SelectedIndexChanged += new System.EventHandler(this.Tenclb_SelectedIndexChanged);
            // 
            // giave
            // 
            this.giave.Location = new System.Drawing.Point(159, 229);
            this.giave.Name = "giave";
            this.giave.Size = new System.Drawing.Size(115, 26);
            this.giave.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "$";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Tenclb);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.sl);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.giave);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Tennuoc);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 459);
            this.panel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataCLB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(433, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 459);
            this.panel1.TabIndex = 11;
            // 
            // dataCLB
            // 
            this.dataCLB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataCLB.Location = new System.Drawing.Point(0, 0);
            this.dataCLB.Name = "dataCLB";
            this.dataCLB.RowHeadersWidth = 62;
            this.dataCLB.RowTemplate.Height = 28;
            this.dataCLB.Size = new System.Drawing.Size(660, 459);
            this.dataCLB.TabIndex = 0;
            this.dataCLB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // errtenclb
            // 
            this.errtenclb.ContainerControl = this;
            // 
            // errtennuoc
            // 
            this.errtennuoc.ContainerControl = this;
            // 
            // errsl
            // 
            this.errsl.ContainerControl = this;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(252, 285);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 44);
            this.button5.TabIndex = 8;
            this.button5.Text = "Tìm kiếm";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(252, 344);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(139, 44);
            this.button6.TabIndex = 8;
            this.button6.Text = "Thống kê";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkLabel1.Location = new System.Drawing.Point(359, 5);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(69, 20);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Làm mới";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 459);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sl)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataCLB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errtenclb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errtennuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errsl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox Tennuoc;
        private System.Windows.Forms.NumericUpDown sl;
        private System.Windows.Forms.ComboBox Tenclb;
        private System.Windows.Forms.TextBox giave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataCLB;
        private System.Windows.Forms.ErrorProvider errtenclb;
        private System.Windows.Forms.ErrorProvider errtennuoc;
        private System.Windows.Forms.ErrorProvider errsl;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

