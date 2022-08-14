
namespace BTL_QuanLySach
{
    partial class FormMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DoiMK = new System.Windows.Forms.PictureBox();
            this.DangXuat = new System.Windows.Forms.PictureBox();
            this.HoSoTra = new Guna.UI2.WinForms.Guna2Button();
            this.HoSoMuon = new Guna.UI2.WinForms.Guna2Button();
            this.TheMuon = new Guna.UI2.WinForms.Guna2Button();
            this.TaiLieu = new Guna.UI2.WinForms.Guna2Button();
            this.ThuThu = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tenUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pn_main = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoiMK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DangXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pn_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DoiMK);
            this.panel1.Controls.Add(this.DangXuat);
            this.panel1.Controls.Add(this.HoSoTra);
            this.panel1.Controls.Add(this.HoSoMuon);
            this.panel1.Controls.Add(this.TheMuon);
            this.panel1.Controls.Add(this.TaiLieu);
            this.panel1.Controls.Add(this.ThuThu);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.tenUser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 586);
            this.panel1.TabIndex = 0;
            // 
            // DoiMK
            // 
            this.DoiMK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoiMK.Image = global::BTL_QuanLySach.Properties.Resources.icons8_password_reset_32px;
            this.DoiMK.Location = new System.Drawing.Point(84, 129);
            this.DoiMK.Name = "DoiMK";
            this.DoiMK.Size = new System.Drawing.Size(35, 35);
            this.DoiMK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DoiMK.TabIndex = 6;
            this.DoiMK.TabStop = false;
            this.toolTip1.SetToolTip(this.DoiMK, "Đổi mật khẩu");
            this.DoiMK.Visible = false;
            this.DoiMK.Click += new System.EventHandler(this.DoiMK_Click);
            // 
            // DangXuat
            // 
            this.DangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DangXuat.Image = global::BTL_QuanLySach.Properties.Resources.icons8_sign_out_50px;
            this.DangXuat.Location = new System.Drawing.Point(141, 129);
            this.DangXuat.Name = "DangXuat";
            this.DangXuat.Size = new System.Drawing.Size(35, 35);
            this.DangXuat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DangXuat.TabIndex = 6;
            this.DangXuat.TabStop = false;
            this.toolTip1.SetToolTip(this.DangXuat, "Đăng xuất");
            this.DangXuat.Visible = false;
            this.DangXuat.Click += new System.EventHandler(this.DangXuat_Click);
            // 
            // HoSoTra
            // 
            this.HoSoTra.BorderRadius = 20;
            this.HoSoTra.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.HoSoTra.CheckedState.FillColor = System.Drawing.Color.White;
            this.HoSoTra.CheckedState.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.HoSoTra.CheckedState.Image = global::BTL_QuanLySach.Properties.Resources.icons8_audit_32px;
            this.HoSoTra.CheckedState.Parent = this.HoSoTra;
            this.HoSoTra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HoSoTra.CustomImages.Parent = this.HoSoTra;
            this.HoSoTra.FillColor = System.Drawing.Color.Transparent;
            this.HoSoTra.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoSoTra.ForeColor = System.Drawing.Color.White;
            this.HoSoTra.HoverState.Parent = this.HoSoTra;
            this.HoSoTra.Image = global::BTL_QuanLySach.Properties.Resources.icons8_audit_32px;
            this.HoSoTra.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HoSoTra.ImageOffset = new System.Drawing.Point(-5, 0);
            this.HoSoTra.ImageSize = new System.Drawing.Size(30, 30);
            this.HoSoTra.Location = new System.Drawing.Point(3, 430);
            this.HoSoTra.Name = "HoSoTra";
            this.HoSoTra.ShadowDecoration.Parent = this.HoSoTra;
            this.HoSoTra.Size = new System.Drawing.Size(177, 43);
            this.HoSoTra.TabIndex = 4;
            this.HoSoTra.Text = "Hồ sơ trả";
            this.HoSoTra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HoSoTra.Click += new System.EventHandler(this.HoSoTra_Click);
            // 
            // HoSoMuon
            // 
            this.HoSoMuon.BorderRadius = 20;
            this.HoSoMuon.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.HoSoMuon.CheckedState.FillColor = System.Drawing.Color.White;
            this.HoSoMuon.CheckedState.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.HoSoMuon.CheckedState.Image = global::BTL_QuanLySach.Properties.Resources.icons8_copybook_32px;
            this.HoSoMuon.CheckedState.Parent = this.HoSoMuon;
            this.HoSoMuon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HoSoMuon.CustomImages.Parent = this.HoSoMuon;
            this.HoSoMuon.FillColor = System.Drawing.Color.Transparent;
            this.HoSoMuon.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoSoMuon.ForeColor = System.Drawing.Color.White;
            this.HoSoMuon.HoverState.Parent = this.HoSoMuon;
            this.HoSoMuon.Image = global::BTL_QuanLySach.Properties.Resources.icons8_copybook_32px;
            this.HoSoMuon.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HoSoMuon.ImageOffset = new System.Drawing.Point(-5, 0);
            this.HoSoMuon.ImageSize = new System.Drawing.Size(32, 32);
            this.HoSoMuon.Location = new System.Drawing.Point(3, 360);
            this.HoSoMuon.Name = "HoSoMuon";
            this.HoSoMuon.ShadowDecoration.Parent = this.HoSoMuon;
            this.HoSoMuon.Size = new System.Drawing.Size(177, 43);
            this.HoSoMuon.TabIndex = 4;
            this.HoSoMuon.Text = "Hồ sơ mượn";
            this.HoSoMuon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HoSoMuon.TextOffset = new System.Drawing.Point(-7, 0);
            this.HoSoMuon.Click += new System.EventHandler(this.HoSoMuon_Click);
            // 
            // TheMuon
            // 
            this.TheMuon.BorderRadius = 20;
            this.TheMuon.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.TheMuon.CheckedState.FillColor = System.Drawing.Color.White;
            this.TheMuon.CheckedState.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TheMuon.CheckedState.Image = global::BTL_QuanLySach.Properties.Resources.icons8_ebook_50px;
            this.TheMuon.CheckedState.Parent = this.TheMuon;
            this.TheMuon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TheMuon.CustomImages.Parent = this.TheMuon;
            this.TheMuon.FillColor = System.Drawing.Color.Transparent;
            this.TheMuon.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheMuon.ForeColor = System.Drawing.Color.White;
            this.TheMuon.HoverState.Parent = this.TheMuon;
            this.TheMuon.Image = global::BTL_QuanLySach.Properties.Resources.icons8_ebook_50px;
            this.TheMuon.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TheMuon.ImageOffset = new System.Drawing.Point(-5, 0);
            this.TheMuon.ImageSize = new System.Drawing.Size(35, 35);
            this.TheMuon.Location = new System.Drawing.Point(3, 290);
            this.TheMuon.Name = "TheMuon";
            this.TheMuon.ShadowDecoration.Parent = this.TheMuon;
            this.TheMuon.Size = new System.Drawing.Size(177, 43);
            this.TheMuon.TabIndex = 4;
            this.TheMuon.Text = "Thẻ mượn";
            this.TheMuon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TheMuon.TextOffset = new System.Drawing.Point(-7, 0);
            this.TheMuon.Click += new System.EventHandler(this.TheMuon_Click);
            // 
            // TaiLieu
            // 
            this.TaiLieu.BorderRadius = 20;
            this.TaiLieu.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.TaiLieu.CheckedState.FillColor = System.Drawing.Color.White;
            this.TaiLieu.CheckedState.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TaiLieu.CheckedState.Image = global::BTL_QuanLySach.Properties.Resources.icons8_books_32px;
            this.TaiLieu.CheckedState.Parent = this.TaiLieu;
            this.TaiLieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TaiLieu.CustomImages.Parent = this.TaiLieu;
            this.TaiLieu.FillColor = System.Drawing.Color.Transparent;
            this.TaiLieu.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaiLieu.ForeColor = System.Drawing.Color.White;
            this.TaiLieu.HoverState.Parent = this.TaiLieu;
            this.TaiLieu.Image = global::BTL_QuanLySach.Properties.Resources.icons8_books_32px;
            this.TaiLieu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TaiLieu.ImageSize = new System.Drawing.Size(30, 30);
            this.TaiLieu.Location = new System.Drawing.Point(3, 150);
            this.TaiLieu.Name = "TaiLieu";
            this.TaiLieu.ShadowDecoration.Parent = this.TaiLieu;
            this.TaiLieu.Size = new System.Drawing.Size(173, 43);
            this.TaiLieu.TabIndex = 4;
            this.TaiLieu.Text = "Giáo trình";
            this.TaiLieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TaiLieu.Click += new System.EventHandler(this.TaiLieu_Click);
            // 
            // ThuThu
            // 
            this.ThuThu.BorderRadius = 20;
            this.ThuThu.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ThuThu.CheckedState.FillColor = System.Drawing.Color.White;
            this.ThuThu.CheckedState.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ThuThu.CheckedState.Image = global::BTL_QuanLySach.Properties.Resources.icons8_advice_32px_1;
            this.ThuThu.CheckedState.Parent = this.ThuThu;
            this.ThuThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ThuThu.CustomImages.Parent = this.ThuThu;
            this.ThuThu.FillColor = System.Drawing.Color.Transparent;
            this.ThuThu.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThuThu.ForeColor = System.Drawing.Color.White;
            this.ThuThu.HoverState.Parent = this.ThuThu;
            this.ThuThu.Image = global::BTL_QuanLySach.Properties.Resources.icons8_advice_32px_1;
            this.ThuThu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ThuThu.ImageSize = new System.Drawing.Size(30, 30);
            this.ThuThu.Location = new System.Drawing.Point(3, 220);
            this.ThuThu.Name = "ThuThu";
            this.ThuThu.ShadowDecoration.Parent = this.ThuThu;
            this.ThuThu.Size = new System.Drawing.Size(173, 43);
            this.ThuThu.TabIndex = 4;
            this.ThuThu.Text = "Thủ thư";
            this.ThuThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ThuThu.Click += new System.EventHandler(this.ThuThu_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::BTL_QuanLySach.Properties.Resources.icons8_contacts_32px;
            this.pictureBox2.Location = new System.Drawing.Point(14, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.tenUser_Click);
            // 
            // tenUser
            // 
            this.tenUser.AutoSize = true;
            this.tenUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tenUser.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenUser.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tenUser.Location = new System.Drawing.Point(49, 103);
            this.tenUser.Name = "tenUser";
            this.tenUser.Size = new System.Drawing.Size(70, 23);
            this.tenUser.TabIndex = 2;
            this.tenUser.Text = "label2";
            this.tenUser.Click += new System.EventHandler(this.tenUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(76, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcom to \r\nBookStore";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::BTL_QuanLySach.Properties.Resources.icons8_google_books_50px;
            this.pictureBox1.Location = new System.Drawing.Point(9, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Về trang chủ");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::BTL_QuanLySach.Properties.Resources.icons8_shutdown_50px;
            this.pictureBox3.Location = new System.Drawing.Point(803, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Thoát");
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 25;
            this.guna2Elipse2.TargetControl = this.pn_main;
            // 
            // pn_main
            // 
            this.pn_main.BackgroundImage = global::BTL_QuanLySach.Properties.Resources.BG;
            this.pn_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_main.Controls.Add(this.pictureBox3);
            this.pn_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_main.Location = new System.Drawing.Point(188, 5);
            this.pn_main.Name = "pn_main";
            this.pn_main.Size = new System.Drawing.Size(827, 576);
            this.pn_main.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(188, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(832, 5);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1015, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 581);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(188, 581);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(827, 5);
            this.panel4.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1020, 586);
            this.Controls.Add(this.pn_main);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoiMK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DangXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pn_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label tenUser;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button ThuThu;
        private Guna.UI2.WinForms.Guna2Button TaiLieu;
        private Guna.UI2.WinForms.Guna2Button HoSoTra;
        private Guna.UI2.WinForms.Guna2Button HoSoMuon;
        private Guna.UI2.WinForms.Guna2Button TheMuon;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.PictureBox DangXuat;
        private System.Windows.Forms.PictureBox DoiMK;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pn_main;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

