
namespace QuanLySach.View
{
    partial class Login
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
            this.TK = new System.Windows.Forms.TextBox();
            this.DangNhap = new System.Windows.Forms.Button();
            this.DangKy = new System.Windows.Forms.LinkLabel();
            this.Thoat = new System.Windows.Forms.Button();
            this.MK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errTK = new System.Windows.Forms.ErrorProvider(this.components);
            this.errMK = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMK)).BeginInit();
            this.SuspendLayout();
            // 
            // TK
            // 
            this.TK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TK.Location = new System.Drawing.Point(468, 230);
            this.TK.Multiline = true;
            this.TK.Name = "TK";
            this.TK.Size = new System.Drawing.Size(264, 41);
            this.TK.TabIndex = 0;
            // 
            // DangNhap
            // 
            this.DangNhap.BackColor = System.Drawing.Color.Transparent;
            this.DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DangNhap.ForeColor = System.Drawing.Color.Indigo;
            this.DangNhap.Location = new System.Drawing.Point(319, 377);
            this.DangNhap.Name = "DangNhap";
            this.DangNhap.Size = new System.Drawing.Size(160, 50);
            this.DangNhap.TabIndex = 2;
            this.DangNhap.Text = "Đăng nhập";
            this.DangNhap.UseVisualStyleBackColor = false;
            this.DangNhap.Click += new System.EventHandler(this.DangNhap_Click);
            // 
            // DangKy
            // 
            this.DangKy.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DangKy.AutoSize = true;
            this.DangKy.BackColor = System.Drawing.Color.Transparent;
            this.DangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DangKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DangKy.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DangKy.Location = new System.Drawing.Point(749, 340);
            this.DangKy.Name = "DangKy";
            this.DangKy.Size = new System.Drawing.Size(104, 25);
            this.DangKy.TabIndex = 4;
            this.DangKy.TabStop = true;
            this.DangKy.Text = "Đăng ký !";
            this.DangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DangKy_LinkClicked);
            // 
            // Thoat
            // 
            this.Thoat.BackColor = System.Drawing.Color.Transparent;
            this.Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.ForeColor = System.Drawing.Color.Indigo;
            this.Thoat.Location = new System.Drawing.Point(567, 377);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(165, 50);
            this.Thoat.TabIndex = 3;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = false;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // MK
            // 
            this.MK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MK.Location = new System.Drawing.Point(468, 277);
            this.MK.Multiline = true;
            this.MK.Name = "MK";
            this.MK.PasswordChar = '*';
            this.MK.Size = new System.Drawing.Size(264, 41);
            this.MK.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(484, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bạn chưa có tài khoản?";
            // 
            // errTK
            // 
            this.errTK.ContainerControl = this;
            // 
            // errMK
            // 
            this.errMK.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLySach.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1053, 558);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.DangNhap);
            this.Controls.Add(this.TK);
            this.Controls.Add(this.MK);
            this.Controls.Add(this.DangKy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DangNhap;
        private System.Windows.Forms.LinkLabel DangKy;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.TextBox MK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errTK;
        private System.Windows.Forms.ErrorProvider errMK;
        private System.Windows.Forms.TextBox TK;
    }
}