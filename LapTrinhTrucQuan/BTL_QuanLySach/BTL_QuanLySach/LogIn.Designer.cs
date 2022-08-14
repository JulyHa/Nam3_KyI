
namespace BTL_QuanLySach
{
    partial class LogIn
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.errTK = new System.Windows.Forms.ErrorProvider(this.components);
            this.errMK = new System.Windows.Forms.ErrorProvider(this.components);
            this.MK = new Guna.UI2.WinForms.Guna2TextBox();
            this.TK = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.show_hide = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_hide)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(278, 462);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(90, 25);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Đăng ký!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Chaparral Pro", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(111, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 50);
            this.label1.TabIndex = 11;
            this.label1.Text = "Đăng nhập";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.SystemColors.HotTrack;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(129, 525);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(180, 52);
            this.guna2Button1.TabIndex = 8;
            this.guna2Button1.Text = "Đăng nhập";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // errTK
            // 
            this.errTK.ContainerControl = this;
            // 
            // errMK
            // 
            this.errMK.ContainerControl = this;
            // 
            // MK
            // 
            this.MK.BorderColor = System.Drawing.Color.White;
            this.MK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MK.DefaultText = "Mật khẩu";
            this.MK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MK.DisabledState.Parent = this.MK;
            this.MK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MK.FocusedState.BorderColor = System.Drawing.Color.White;
            this.MK.FocusedState.Parent = this.MK;
            this.MK.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MK.ForeColor = System.Drawing.Color.DarkGray;
            this.MK.HoverState.BorderColor = System.Drawing.Color.White;
            this.MK.HoverState.Parent = this.MK;
            this.MK.IconLeft = global::BTL_QuanLySach.Properties.Resources.icons8_secure_50px;
            this.MK.IconLeftSize = new System.Drawing.Size(30, 30);
            this.MK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MK.Location = new System.Drawing.Point(51, 384);
            this.MK.Margin = new System.Windows.Forms.Padding(17, 8, 17, 8);
            this.MK.Name = "MK";
            this.MK.PasswordChar = '\0';
            this.MK.PlaceholderText = "";
            this.MK.SelectedText = "";
            this.MK.SelectionStart = 8;
            this.MK.ShadowDecoration.Parent = this.MK;
            this.MK.Size = new System.Drawing.Size(317, 52);
            this.MK.TabIndex = 9;
            this.MK.TextOffset = new System.Drawing.Point(10, 0);
            this.MK.TextChanged += new System.EventHandler(this.MK_TextChanged);
            this.MK.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MK_MouseClick);
            // 
            // TK
            // 
            this.TK.BorderColor = System.Drawing.Color.White;
            this.TK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TK.DefaultText = "Tài khoản";
            this.TK.DisabledState.BorderColor = System.Drawing.Color.White;
            this.TK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TK.DisabledState.Parent = this.TK;
            this.TK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TK.FocusedState.BorderColor = System.Drawing.Color.White;
            this.TK.FocusedState.Parent = this.TK;
            this.TK.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TK.ForeColor = System.Drawing.Color.DarkGray;
            this.TK.HoverState.BorderColor = System.Drawing.Color.White;
            this.TK.HoverState.Parent = this.TK;
            this.TK.IconLeft = global::BTL_QuanLySach.Properties.Resources.icons8_male_user_50px;
            this.TK.IconLeftSize = new System.Drawing.Size(30, 30);
            this.TK.Location = new System.Drawing.Point(51, 264);
            this.TK.Margin = new System.Windows.Forms.Padding(14, 8, 14, 8);
            this.TK.Name = "TK";
            this.TK.PasswordChar = '\0';
            this.TK.PlaceholderText = "";
            this.TK.SelectedText = "";
            this.TK.SelectionStart = 9;
            this.TK.ShadowDecoration.Parent = this.TK;
            this.TK.Size = new System.Drawing.Size(317, 51);
            this.TK.TabIndex = 10;
            this.TK.TextOffset = new System.Drawing.Point(10, 0);
            this.TK.TextChanged += new System.EventHandler(this.TK_TextChanged);
            this.TK.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TK_MouseClick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::BTL_QuanLySach.Properties.Resources.icons8_google_books_50px;
            this.pictureBox4.Location = new System.Drawing.Point(170, 60);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(104, 90);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::BTL_QuanLySach.Properties.Resources.icons8_delete_50px_1;
            this.pictureBox3.Location = new System.Drawing.Point(394, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BTL_QuanLySach.Properties.Resources.icons8_horizontal_line_50px;
            this.pictureBox2.Location = new System.Drawing.Point(99, 417);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(269, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BTL_QuanLySach.Properties.Resources.icons8_horizontal_line_50px;
            this.pictureBox1.Location = new System.Drawing.Point(99, 297);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // show_hide
            // 
            this.show_hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_hide.Image = global::BTL_QuanLySach.Properties.Resources.icons8_hide_50px;
            this.show_hide.Location = new System.Drawing.Point(329, 397);
            this.show_hide.Name = "show_hide";
            this.show_hide.Size = new System.Drawing.Size(34, 39);
            this.show_hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.show_hide.TabIndex = 17;
            this.show_hide.TabStop = false;
            this.show_hide.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(439, 634);
            this.Controls.Add(this.show_hide);
            this.Controls.Add(this.MK);
            this.Controls.Add(this.TK);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_hide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2TextBox MK;
        private Guna.UI2.WinForms.Guna2TextBox TK;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errTK;
        private System.Windows.Forms.ErrorProvider errMK;
        private System.Windows.Forms.PictureBox show_hide;
    }
}