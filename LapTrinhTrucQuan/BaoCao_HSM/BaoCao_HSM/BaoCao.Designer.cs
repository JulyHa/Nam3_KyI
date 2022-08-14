
namespace BaoCao_HSM
{
    partial class BaoCao
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaThe = new System.Windows.Forms.ComboBox();
            this.lbMaThe = new System.Windows.Forms.Label();
            this.btnTao = new System.Windows.Forms.Button();
            this.cmbBaoCaoTheo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rptHSM = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtMaThe);
            this.panel1.Controls.Add(this.lbMaThe);
            this.panel1.Controls.Add(this.btnTao);
            this.panel1.Controls.Add(this.cmbBaoCaoTheo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 112);
            this.panel1.TabIndex = 0;
            // 
            // txtMaThe
            // 
            this.txtMaThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaThe.FormattingEnabled = true;
            this.txtMaThe.Location = new System.Drawing.Point(479, 40);
            this.txtMaThe.Name = "txtMaThe";
            this.txtMaThe.Size = new System.Drawing.Size(160, 30);
            this.txtMaThe.TabIndex = 5;
            // 
            // lbMaThe
            // 
            this.lbMaThe.AutoSize = true;
            this.lbMaThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaThe.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbMaThe.Location = new System.Drawing.Point(388, 41);
            this.lbMaThe.Name = "lbMaThe";
            this.lbMaThe.Size = new System.Drawing.Size(85, 25);
            this.lbMaThe.TabIndex = 4;
            this.lbMaThe.Text = "Mã thẻ:";
            // 
            // btnTao
            // 
            this.btnTao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTao.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTao.ForeColor = System.Drawing.Color.White;
            this.btnTao.Location = new System.Drawing.Point(689, 29);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(108, 52);
            this.btnTao.TabIndex = 2;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = false;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // cmbBaoCaoTheo
            // 
            this.cmbBaoCaoTheo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBaoCaoTheo.FormattingEnabled = true;
            this.cmbBaoCaoTheo.Items.AddRange(new object[] {
            "Thẻ mượn cho trước",
            "Giáo trình đang được mượn chưa trả"});
            this.cmbBaoCaoTheo.Location = new System.Drawing.Point(164, 40);
            this.cmbBaoCaoTheo.Name = "cmbBaoCaoTheo";
            this.cmbBaoCaoTheo.Size = new System.Drawing.Size(199, 30);
            this.cmbBaoCaoTheo.TabIndex = 1;
            this.cmbBaoCaoTheo.SelectedIndexChanged += new System.EventHandler(this.cmbBaoCaoTheo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo cáo theo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rptHSM);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(0, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 464);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết quả báo cáo";
            // 
            // rptHSM
            // 
            this.rptHSM.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rptHSM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptHSM.Location = new System.Drawing.Point(3, 22);
            this.rptHSM.Name = "rptHSM";
            this.rptHSM.ServerReport.BearerToken = null;
            this.rptHSM.Size = new System.Drawing.Size(821, 439);
            this.rptHSM.TabIndex = 0;
            // 
            // BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 576);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaoCao";
            this.Text = "Báo cáo hồ sơ mượn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.ComboBox cmbBaoCaoTheo;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer rptHSM;
        private System.Windows.Forms.Label lbMaThe;
        private System.Windows.Forms.ComboBox txtMaThe;
    }
}

