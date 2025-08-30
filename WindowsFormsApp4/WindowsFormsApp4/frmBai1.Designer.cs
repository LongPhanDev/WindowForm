namespace WindowsFormsApp4
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnMaThietBi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNuocSX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMaThietBi,
            this.columnTen,
            this.columnNuocSX,
            this.columnDonGia,
            this.columnSoLuong,
            this.columnThanhTien});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 397);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnMaThietBi
            // 
            this.columnMaThietBi.Text = "Mã thiết bị";
            this.columnMaThietBi.Width = 80;
            // 
            // columnTen
            // 
            this.columnTen.Text = "Tên thiết bị";
            this.columnTen.Width = 150;
            // 
            // columnNuocSX
            // 
            this.columnNuocSX.Text = "Nước sản xuất";
            this.columnNuocSX.Width = 130;
            // 
            // columnDonGia
            // 
            this.columnDonGia.Text = "Đơn giá";
            this.columnDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnDonGia.Width = 100;
            // 
            // columnSoLuong
            // 
            this.columnSoLuong.Text = "Số lượng";
            this.columnSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnSoLuong.Width = 80;
            // 
            // columnThanhTien
            // 
            this.columnThanhTien.Text = "Thành tiền";
            this.columnThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnThanhTien.Width = 120;
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 397);
            this.Controls.Add(this.listView1);
            this.Name = "frmBai1";
            this.Text = "Thông tin thiết bị";
            this.Load += new System.EventHandler(this.frmBai1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnMaThietBi;
        private System.Windows.Forms.ColumnHeader columnTen;
        private System.Windows.Forms.ColumnHeader columnNuocSX;
        private System.Windows.Forms.ColumnHeader columnDonGia;
        private System.Windows.Forms.ColumnHeader columnSoLuong;
        private System.Windows.Forms.ColumnHeader columnThanhTien;
    }
}