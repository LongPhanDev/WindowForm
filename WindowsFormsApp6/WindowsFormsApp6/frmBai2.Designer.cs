namespace WindowsFormsApp6
{
    partial class frmBai2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKetQuaXepLoai = new System.Windows.Forms.Label();
            this.txtDiemLyThuyet = new System.Windows.Forms.TextBox();
            this.txtDiemThucHanh = new System.Windows.Forms.TextBox();
            this.btnKetQua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập điểm lý thuyết:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập điểm thực hành:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết quả xếp loại:";
            // 
            // lblKetQuaXepLoai
            // 
            this.lblKetQuaXepLoai.AutoSize = true;
            this.lblKetQuaXepLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQuaXepLoai.ForeColor = System.Drawing.Color.Red;
            this.lblKetQuaXepLoai.Location = new System.Drawing.Point(252, 279);
            this.lblKetQuaXepLoai.Name = "lblKetQuaXepLoai";
            this.lblKetQuaXepLoai.Size = new System.Drawing.Size(31, 29);
            this.lblKetQuaXepLoai.TabIndex = 3;
            this.lblKetQuaXepLoai.Text = "...";
            // 
            // txtDiemLyThuyet
            // 
            this.txtDiemLyThuyet.Location = new System.Drawing.Point(257, 83);
            this.txtDiemLyThuyet.Name = "txtDiemLyThuyet";
            this.txtDiemLyThuyet.Size = new System.Drawing.Size(96, 22);
            this.txtDiemLyThuyet.TabIndex = 4;
            // 
            // txtDiemThucHanh
            // 
            this.txtDiemThucHanh.Location = new System.Drawing.Point(257, 143);
            this.txtDiemThucHanh.Name = "txtDiemThucHanh";
            this.txtDiemThucHanh.Size = new System.Drawing.Size(96, 22);
            this.txtDiemThucHanh.TabIndex = 5;
            // 
            // btnKetQua
            // 
            this.btnKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetQua.Location = new System.Drawing.Point(257, 187);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(96, 34);
            this.btnKetQua.TabIndex = 6;
            this.btnKetQua.Text = "Xếp loại";
            this.btnKetQua.UseVisualStyleBackColor = true;
            this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKetQua);
            this.Controls.Add(this.txtDiemThucHanh);
            this.Controls.Add(this.txtDiemLyThuyet);
            this.Controls.Add(this.lblKetQuaXepLoai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai2";
            this.Text = "Xếp loại";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKetQuaXepLoai;
        private System.Windows.Forms.TextBox txtDiemLyThuyet;
        private System.Windows.Forms.TextBox txtDiemThucHanh;
        private System.Windows.Forms.Button btnKetQua;
    }
}