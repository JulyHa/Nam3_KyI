
namespace TimKiemThuThu
{
    partial class TKThuThu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoTT_Nhan_SachTra = new System.Windows.Forms.RadioButton();
            this.rdoTenTT = new System.Windows.Forms.RadioButton();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTKThuThu = new System.Windows.Forms.TextBox();
            this.dgvThuThu = new System.Windows.Forms.DataGridView();
            this.rdoMaTT = new System.Windows.Forms.RadioButton();
            this.rdoQue = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuThu)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.rdoQue);
            this.groupBox1.Controls.Add(this.rdoMaTT);
            this.groupBox1.Controls.Add(this.rdoTT_Nhan_SachTra);
            this.groupBox1.Controls.Add(this.rdoTenTT);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Indigo;
            this.groupBox1.Location = new System.Drawing.Point(247, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 112);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm thủ thư theo:";
            // 
            // rdoTT_Nhan_SachTra
            // 
            this.rdoTT_Nhan_SachTra.AutoSize = true;
            this.rdoTT_Nhan_SachTra.Font = new System.Drawing.Font("Lucida Calligraphy", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTT_Nhan_SachTra.ForeColor = System.Drawing.Color.DeepPink;
            this.rdoTT_Nhan_SachTra.Location = new System.Drawing.Point(40, 70);
            this.rdoTT_Nhan_SachTra.Name = "rdoTT_Nhan_SachTra";
            this.rdoTT_Nhan_SachTra.Size = new System.Drawing.Size(416, 25);
            this.rdoTT_Nhan_SachTra.TabIndex = 1;
            this.rdoTT_Nhan_SachTra.TabStop = true;
            this.rdoTT_Nhan_SachTra.Text = "Danh sách các hồ sơ thủ thử đã nhận sách trả";
            this.rdoTT_Nhan_SachTra.UseVisualStyleBackColor = true;
            // 
            // rdoTenTT
            // 
            this.rdoTenTT.AutoSize = true;
            this.rdoTenTT.Font = new System.Drawing.Font("Lucida Calligraphy", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTenTT.ForeColor = System.Drawing.Color.DeepPink;
            this.rdoTenTT.Location = new System.Drawing.Point(40, 34);
            this.rdoTenTT.Name = "rdoTenTT";
            this.rdoTenTT.Size = new System.Drawing.Size(130, 25);
            this.rdoTenTT.TabIndex = 0;
            this.rdoTenTT.TabStop = true;
            this.rdoTenTT.Text = "Tên thủ thư";
            this.rdoTenTT.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTim.Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnTim.Location = new System.Drawing.Point(297, 134);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(101, 41);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTKThuThu
            // 
            this.txtTKThuThu.BackColor = System.Drawing.Color.White;
            this.txtTKThuThu.Location = new System.Drawing.Point(434, 142);
            this.txtTKThuThu.Multiline = true;
            this.txtTKThuThu.Name = "txtTKThuThu";
            this.txtTKThuThu.Size = new System.Drawing.Size(261, 29);
            this.txtTKThuThu.TabIndex = 3;
            // 
            // dgvThuThu
            // 
            this.dgvThuThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuThu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(255)))), ((int)(((byte)(212)))));
            this.dgvThuThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuThu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvThuThu.Location = new System.Drawing.Point(0, 187);
            this.dgvThuThu.Name = "dgvThuThu";
            this.dgvThuThu.RowHeadersWidth = 62;
            this.dgvThuThu.RowTemplate.Height = 28;
            this.dgvThuThu.Size = new System.Drawing.Size(998, 333);
            this.dgvThuThu.TabIndex = 4;
            // 
            // rdoMaTT
            // 
            this.rdoMaTT.AutoSize = true;
            this.rdoMaTT.Font = new System.Drawing.Font("Lucida Calligraphy", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMaTT.ForeColor = System.Drawing.Color.DeepPink;
            this.rdoMaTT.Location = new System.Drawing.Point(219, 34);
            this.rdoMaTT.Name = "rdoMaTT";
            this.rdoMaTT.Size = new System.Drawing.Size(129, 25);
            this.rdoMaTT.TabIndex = 2;
            this.rdoMaTT.TabStop = true;
            this.rdoMaTT.Text = "Mã thủ thư";
            this.rdoMaTT.UseVisualStyleBackColor = true;
            // 
            // rdoQue
            // 
            this.rdoQue.AutoSize = true;
            this.rdoQue.Font = new System.Drawing.Font("Lucida Calligraphy", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoQue.ForeColor = System.Drawing.Color.DeepPink;
            this.rdoQue.Location = new System.Drawing.Point(389, 34);
            this.rdoQue.Name = "rdoQue";
            this.rdoQue.Size = new System.Drawing.Size(67, 25);
            this.rdoQue.TabIndex = 4;
            this.rdoQue.TabStop = true;
            this.rdoQue.Text = "Quê";
            this.rdoQue.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.txtTKThuThu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 185);
            this.panel1.TabIndex = 5;
            // 
            // TKThuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(998, 520);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvThuThu);
            this.Name = "TKThuThu";
            this.Text = "Tìm kiếm thủ thư";
            this.Load += new System.EventHandler(this.TKThuThu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuThu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoTT_Nhan_SachTra;
        private System.Windows.Forms.RadioButton rdoTenTT;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTKThuThu;
        private System.Windows.Forms.DataGridView dgvThuThu;
        private System.Windows.Forms.RadioButton rdoQue;
        private System.Windows.Forms.RadioButton rdoMaTT;
        private System.Windows.Forms.Panel panel1;
    }
}