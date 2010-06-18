namespace Presentation
{
    partial class PhieuNhapSach
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
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ngayNhap = new System.Windows.Forms.DateTimePicker();
            this.PhieuNhapGrid = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PhieuNhapGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(215, 239);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ngày nhập";
            // 
            // ngayNhap
            // 
            this.ngayNhap.Location = new System.Drawing.Point(239, 12);
            this.ngayNhap.Name = "ngayNhap";
            this.ngayNhap.Size = new System.Drawing.Size(200, 20);
            this.ngayNhap.TabIndex = 3;
            // 
            // PhieuNhapGrid
            // 
            this.PhieuNhapGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PhieuNhapGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Sach,
            this.TheLoai,
            this.TacGia,
            this.SoLuong});
            this.PhieuNhapGrid.Location = new System.Drawing.Point(12, 39);
            this.PhieuNhapGrid.Name = "PhieuNhapGrid";
            this.PhieuNhapGrid.Size = new System.Drawing.Size(597, 194);
            this.PhieuNhapGrid.TabIndex = 4;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // Sach
            // 
            this.Sach.HeaderText = "Sách";
            this.Sach.Name = "Sach";
            this.Sach.Width = 200;
            // 
            // TheLoai
            // 
            this.TheLoai.HeaderText = "Thể Loại";
            this.TheLoai.Name = "TheLoai";
            // 
            // TacGia
            // 
            this.TacGia.HeaderText = "Tác Giả";
            this.TacGia.Name = "TacGia";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // btnBo
            // 
            this.btnBo.Location = new System.Drawing.Point(330, 239);
            this.btnBo.Name = "btnBo";
            this.btnBo.Size = new System.Drawing.Size(75, 23);
            this.btnBo.TabIndex = 5;
            this.btnBo.Text = "Bỏ";
            this.btnBo.UseVisualStyleBackColor = true;
            this.btnBo.Click += new System.EventHandler(this.btnBo_Click);
            // 
            // PhieuNhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 270);
            this.Controls.Add(this.btnBo);
            this.Controls.Add(this.PhieuNhapGrid);
            this.Controls.Add(this.ngayNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThem);
            this.Name = "PhieuNhapSach";
            this.Text = "PhieuNhapSach";
            ((System.ComponentModel.ISupportInitialize)(this.PhieuNhapGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ngayNhap;
        private System.Windows.Forms.DataGridView PhieuNhapGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.Button btnBo;
    }
}