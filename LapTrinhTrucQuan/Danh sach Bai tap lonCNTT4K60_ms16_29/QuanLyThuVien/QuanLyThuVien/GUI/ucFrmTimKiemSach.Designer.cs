namespace QuanLyThuVien
{
    partial class ucFrmTimKiemSach
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.rdoBtnTinhTrang = new System.Windows.Forms.RadioButton();
            this.rdoBtnTacGia = new System.Windows.Forms.RadioButton();
            this.rdoBtnTheLoai = new System.Windows.Forms.RadioButton();
            this.rdoBtnTenSach = new System.Windows.Forms.RadioButton();
            this.rdoBtnMaSach = new System.Windows.Forms.RadioButton();
            this.rdoBtnNhaXuatBan = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 170);
            this.panel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.rdoBtnTinhTrang);
            this.groupControl1.Controls.Add(this.rdoBtnTacGia);
            this.groupControl1.Controls.Add(this.rdoBtnTheLoai);
            this.groupControl1.Controls.Add(this.rdoBtnTenSach);
            this.groupControl1.Controls.Add(this.rdoBtnMaSach);
            this.groupControl1.Controls.Add(this.rdoBtnNhaXuatBan);
            this.groupControl1.Location = new System.Drawing.Point(227, 33);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(298, 124);
            this.groupControl1.TabIndex = 14;
            this.groupControl1.Text = "Tìm Kiếm Theo:";
            // 
            // rdoBtnTinhTrang
            // 
            this.rdoBtnTinhTrang.AutoSize = true;
            this.rdoBtnTinhTrang.Location = new System.Drawing.Point(166, 59);
            this.rdoBtnTinhTrang.Margin = new System.Windows.Forms.Padding(2);
            this.rdoBtnTinhTrang.Name = "rdoBtnTinhTrang";
            this.rdoBtnTinhTrang.Size = new System.Drawing.Size(76, 17);
            this.rdoBtnTinhTrang.TabIndex = 10;
            this.rdoBtnTinhTrang.Text = "Tình Trạng";
            this.rdoBtnTinhTrang.UseVisualStyleBackColor = true;
            // 
            // rdoBtnTacGia
            // 
            this.rdoBtnTacGia.AutoSize = true;
            this.rdoBtnTacGia.Location = new System.Drawing.Point(166, 23);
            this.rdoBtnTacGia.Margin = new System.Windows.Forms.Padding(2);
            this.rdoBtnTacGia.Name = "rdoBtnTacGia";
            this.rdoBtnTacGia.Size = new System.Drawing.Size(60, 17);
            this.rdoBtnTacGia.TabIndex = 9;
            this.rdoBtnTacGia.Text = "Tác Giả";
            this.rdoBtnTacGia.UseVisualStyleBackColor = true;
            // 
            // rdoBtnTheLoai
            // 
            this.rdoBtnTheLoai.AutoSize = true;
            this.rdoBtnTheLoai.Location = new System.Drawing.Point(70, 93);
            this.rdoBtnTheLoai.Margin = new System.Windows.Forms.Padding(2);
            this.rdoBtnTheLoai.Name = "rdoBtnTheLoai";
            this.rdoBtnTheLoai.Size = new System.Drawing.Size(65, 17);
            this.rdoBtnTheLoai.TabIndex = 9;
            this.rdoBtnTheLoai.Text = "Thể Loại";
            this.rdoBtnTheLoai.UseVisualStyleBackColor = true;
            // 
            // rdoBtnTenSach
            // 
            this.rdoBtnTenSach.AutoSize = true;
            this.rdoBtnTenSach.Location = new System.Drawing.Point(70, 59);
            this.rdoBtnTenSach.Margin = new System.Windows.Forms.Padding(2);
            this.rdoBtnTenSach.Name = "rdoBtnTenSach";
            this.rdoBtnTenSach.Size = new System.Drawing.Size(69, 17);
            this.rdoBtnTenSach.TabIndex = 9;
            this.rdoBtnTenSach.Text = "Tên Sách";
            this.rdoBtnTenSach.UseVisualStyleBackColor = true;
            // 
            // rdoBtnMaSach
            // 
            this.rdoBtnMaSach.AutoSize = true;
            this.rdoBtnMaSach.Checked = true;
            this.rdoBtnMaSach.Location = new System.Drawing.Point(70, 23);
            this.rdoBtnMaSach.Margin = new System.Windows.Forms.Padding(2);
            this.rdoBtnMaSach.Name = "rdoBtnMaSach";
            this.rdoBtnMaSach.Size = new System.Drawing.Size(65, 17);
            this.rdoBtnMaSach.TabIndex = 9;
            this.rdoBtnMaSach.TabStop = true;
            this.rdoBtnMaSach.Text = "Mã Sách";
            this.rdoBtnMaSach.UseVisualStyleBackColor = true;
            // 
            // rdoBtnNhaXuatBan
            // 
            this.rdoBtnNhaXuatBan.AutoSize = true;
            this.rdoBtnNhaXuatBan.Location = new System.Drawing.Point(166, 93);
            this.rdoBtnNhaXuatBan.Margin = new System.Windows.Forms.Padding(2);
            this.rdoBtnNhaXuatBan.Name = "rdoBtnNhaXuatBan";
            this.rdoBtnNhaXuatBan.Size = new System.Drawing.Size(90, 17);
            this.rdoBtnNhaXuatBan.TabIndex = 9;
            this.rdoBtnNhaXuatBan.Text = "Nhà Xuất Bản";
            this.rdoBtnNhaXuatBan.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(297, 9);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(228, 20);
            this.txtTimKiem.TabIndex = 12;
            this.txtTimKiem.EditValueChanged += new System.EventHandler(this.txtTimKiem_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.labelControl1.Location = new System.Drawing.Point(227, 13);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 16);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Tìm Kiếm:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(762, 288);
            this.panel2.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(762, 288);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã Sách";
            this.gridColumn1.FieldName = "MaSach";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 88;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên Sách";
            this.gridColumn2.FieldName = "TenSach";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 131;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tác Giả";
            this.gridColumn3.FieldName = "TacGia";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 131;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Thể Loại";
            this.gridColumn4.FieldName = "TheLoai";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 131;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Nhà Xuất Bản";
            this.gridColumn5.FieldName = "NhaXuatBan";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 131;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Tình Trạng";
            this.gridColumn6.FieldName = "TinhTrang";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 132;
            // 
            // ucFrmTimKiemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucFrmTimKiemSach";
            this.Size = new System.Drawing.Size(762, 458);
            this.Load += new System.EventHandler(this.ucFrmTimKiemSach_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RadioButton rdoBtnTacGia;
        private System.Windows.Forms.RadioButton rdoBtnTheLoai;
        private System.Windows.Forms.RadioButton rdoBtnTenSach;
        private System.Windows.Forms.RadioButton rdoBtnMaSach;
        private System.Windows.Forms.RadioButton rdoBtnNhaXuatBan;
        private DevExpress.XtraEditors.TextEdit txtTimKiem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private System.Windows.Forms.RadioButton rdoBtnTinhTrang;
    }
}
