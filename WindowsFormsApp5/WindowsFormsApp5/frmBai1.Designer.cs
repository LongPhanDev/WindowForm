namespace WindowsFormsApp5
{
    partial class frmBai1
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
            this.listNV = new System.Windows.Forms.ListView();
            this.columnMaNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHSL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHSPC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTongLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listNV
            // 
            this.listNV.CheckBoxes = true;
            this.listNV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMaNV,
            this.columnHoTen,
            this.columnNgaySinh,
            this.columnHSL,
            this.columnHSPC,
            this.columnTongLuong});
            this.listNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listNV.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listNV.GridLines = true;
            this.listNV.HideSelection = false;
            this.listNV.Location = new System.Drawing.Point(0, 0);
            this.listNV.Name = "listNV";
            this.listNV.Size = new System.Drawing.Size(900, 450);
            this.listNV.TabIndex = 0;
            this.listNV.UseCompatibleStateImageBehavior = false;
            this.listNV.View = System.Windows.Forms.View.Details;
            this.listNV.SelectedIndexChanged += new System.EventHandler(this.listNV_SelectedIndexChanged);
            // 
            // columnMaNV
            // 
            this.columnMaNV.Text = "Mã Nhân viên";
            this.columnMaNV.Width = 100;
            // 
            // columnHoTen
            // 
            this.columnHoTen.Text = "Họ Tên";
            this.columnHoTen.Width = 140;
            // 
            // columnNgaySinh
            // 
            this.columnNgaySinh.Text = "Ngày sinh";
            this.columnNgaySinh.Width = 101;
            // 
            // columnHSL
            // 
            this.columnHSL.Text = "Hệ số lương";
            this.columnHSL.Width = 115;
            // 
            // columnHSPC
            // 
            this.columnHSPC.Text = "Hệ số phụ cấp";
            this.columnHSPC.Width = 118;
            // 
            // columnTongLuong
            // 
            this.columnTongLuong.Text = "Tổng lương";
            this.columnTongLuong.Width = 100;
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.listNV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBai1";
            this.Text = "Thông tin nhân viên";
            this.Load += new System.EventHandler(this.frmBai1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listNV;
        private System.Windows.Forms.ColumnHeader columnMaNV;
        private System.Windows.Forms.ColumnHeader columnHoTen;
        private System.Windows.Forms.ColumnHeader columnNgaySinh;
        private System.Windows.Forms.ColumnHeader columnHSL;
        private System.Windows.Forms.ColumnHeader columnHSPC;
        private System.Windows.Forms.ColumnHeader columnTongLuong;
    }
}