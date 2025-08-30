namespace WindowsFormsApp5
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
            this.txtNhapSoN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTinhGiaiThua = new System.Windows.Forms.RadioButton();
            this.rdTinhTong = new System.Windows.Forms.RadioButton();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnKetQua = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập một số nguyên dương N:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kết quả là:";
            // 
            // txtNhapSoN
            // 
            this.txtNhapSoN.Location = new System.Drawing.Point(319, 29);
            this.txtNhapSoN.Name = "txtNhapSoN";
            this.txtNhapSoN.Size = new System.Drawing.Size(157, 22);
            this.txtNhapSoN.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTinhGiaiThua);
            this.groupBox1.Controls.Add(this.rdTinhTong);
            this.groupBox1.Location = new System.Drawing.Point(232, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 160);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn công việc";
            // 
            // rdTinhGiaiThua
            // 
            this.rdTinhGiaiThua.AutoSize = true;
            this.rdTinhGiaiThua.Location = new System.Drawing.Point(60, 93);
            this.rdTinhGiaiThua.Name = "rdTinhGiaiThua";
            this.rdTinhGiaiThua.Size = new System.Drawing.Size(144, 20);
            this.rdTinhGiaiThua.TabIndex = 1;
            this.rdTinhGiaiThua.Text = "Tính N giai thừa (N!)";
            this.rdTinhGiaiThua.UseVisualStyleBackColor = true;
            // 
            // rdTinhTong
            // 
            this.rdTinhTong.AutoSize = true;
            this.rdTinhTong.Checked = true;
            this.rdTinhTong.Location = new System.Drawing.Point(60, 34);
            this.rdTinhTong.Name = "rdTinhTong";
            this.rdTinhTong.Size = new System.Drawing.Size(133, 20);
            this.rdTinhTong.TabIndex = 0;
            this.rdTinhTong.TabStop = true;
            this.rdTinhTong.Text = "Tính tổng 1+2+...N";
            this.rdTinhTong.UseVisualStyleBackColor = true;
            // 
            // txtKetQua
            // 
            this.txtKetQua.BackColor = System.Drawing.Color.White;
            this.txtKetQua.ForeColor = System.Drawing.Color.Black;
            this.txtKetQua.Location = new System.Drawing.Point(232, 377);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(244, 22);
            this.txtKetQua.TabIndex = 4;
            // 
            // btnKetQua
            // 
            this.btnKetQua.BackColor = System.Drawing.Color.White;
            this.btnKetQua.ForeColor = System.Drawing.Color.Black;
            this.btnKetQua.Location = new System.Drawing.Point(232, 254);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(244, 62);
            this.btnKetQua.TabIndex = 5;
            this.btnKetQua.Text = "Xem kêt quả";
            this.btnKetQua.UseVisualStyleBackColor = false;
            this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(629, 450);
            this.Controls.Add(this.btnKetQua);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNhapSoN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai2";
            this.Text = "Tổng và giai thừa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhapSoN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTinhGiaiThua;
        private System.Windows.Forms.RadioButton rdTinhTong;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnKetQua;
    }
}