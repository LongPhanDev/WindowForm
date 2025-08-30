namespace WindowsFormsApp6
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
            this.listSP = new System.Windows.Forms.ListView();
            this.columnMaSanPham = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTenSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLoaiSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNgaySX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNamHetHan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listSP
            // 
            this.listSP.CheckBoxes = true;
            this.listSP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMaSanPham,
            this.columnTenSP,
            this.columnLoaiSP,
            this.columnNgaySX,
            this.columnNamHetHan});
            this.listSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSP.GridLines = true;
            this.listSP.HideSelection = false;
            this.listSP.Location = new System.Drawing.Point(0, 0);
            this.listSP.Name = "listSP";
            this.listSP.Size = new System.Drawing.Size(800, 450);
            this.listSP.TabIndex = 0;
            this.listSP.UseCompatibleStateImageBehavior = false;
            this.listSP.View = System.Windows.Forms.View.Details;
            // 
            // columnMaSanPham
            // 
            this.columnMaSanPham.Text = "Mã sản phẩm";
            this.columnMaSanPham.Width = 100;
            // 
            // columnTenSP
            // 
            this.columnTenSP.Text = "Tên sản phẩm";
            this.columnTenSP.Width = 120;
            // 
            // columnLoaiSP
            // 
            this.columnLoaiSP.Text = "Loại sản phẩm";
            this.columnLoaiSP.Width = 120;
            // 
            // columnNgaySX
            // 
            this.columnNgaySX.Text = "Ngày sản xuất";
            this.columnNgaySX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnNgaySX.Width = 120;
            // 
            // columnNamHetHan
            // 
            this.columnNamHetHan.Text = "Năm hết hạn";
            this.columnNamHetHan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnNamHetHan.Width = 100;
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listSP);
            this.Name = "frmBai1";
            this.Text = "Thông tin sản phẩm";
            this.Load += new System.EventHandler(this.frmBai1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listSP;
        private System.Windows.Forms.ColumnHeader columnMaSanPham;
        private System.Windows.Forms.ColumnHeader columnTenSP;
        private System.Windows.Forms.ColumnHeader columnLoaiSP;
        private System.Windows.Forms.ColumnHeader columnNgaySX;
        private System.Windows.Forms.ColumnHeader columnNamHetHan;
    }
}