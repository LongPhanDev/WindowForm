namespace WindowsFormsApp4
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
            this.txtSoThuNhat = new System.Windows.Forms.TextBox();
            this.txtSoThuHai = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoCong = new System.Windows.Forms.RadioButton();
            this.rdoTru = new System.Windows.Forms.RadioButton();
            this.rdoNhan = new System.Windows.Forms.RadioButton();
            this.rdoChia = new System.Windows.Forms.RadioButton();
            this.btnXemKetQua = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số thứ nhất:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số thứ hai:";
            // 
            // txtSoThuNhat
            // 
            this.txtSoThuNhat.Location = new System.Drawing.Point(177, 28);
            this.txtSoThuNhat.Name = "txtSoThuNhat";
            this.txtSoThuNhat.Size = new System.Drawing.Size(134, 22);
            this.txtSoThuNhat.TabIndex = 0;
            // 
            // txtSoThuHai
            // 
            this.txtSoThuHai.Location = new System.Drawing.Point(177, 87);
            this.txtSoThuHai.Name = "txtSoThuHai";
            this.txtSoThuHai.Size = new System.Drawing.Size(134, 22);
            this.txtSoThuHai.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoChia);
            this.groupBox1.Controls.Add(this.rdoNhan);
            this.groupBox1.Controls.Add(this.rdoTru);
            this.groupBox1.Controls.Add(this.rdoCong);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(451, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 225);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phép toán:";
            // 
            // rdoCong
            // 
            this.rdoCong.AutoSize = true;
            this.rdoCong.Location = new System.Drawing.Point(35, 35);
            this.rdoCong.Name = "rdoCong";
            this.rdoCong.Size = new System.Drawing.Size(68, 24);
            this.rdoCong.TabIndex = 0;
            this.rdoCong.Text = "Cộng";
            this.rdoCong.UseVisualStyleBackColor = true;
            // 
            // rdoTru
            // 
            this.rdoTru.AutoSize = true;
            this.rdoTru.Checked = true;
            this.rdoTru.Location = new System.Drawing.Point(35, 81);
            this.rdoTru.Name = "rdoTru";
            this.rdoTru.Size = new System.Drawing.Size(57, 24);
            this.rdoTru.TabIndex = 1;
            this.rdoTru.TabStop = true;
            this.rdoTru.Text = "Trừ";
            this.rdoTru.UseVisualStyleBackColor = true;
            // 
            // rdoNhan
            // 
            this.rdoNhan.AutoSize = true;
            this.rdoNhan.Location = new System.Drawing.Point(35, 120);
            this.rdoNhan.Name = "rdoNhan";
            this.rdoNhan.Size = new System.Drawing.Size(69, 24);
            this.rdoNhan.TabIndex = 2;
            this.rdoNhan.Text = "Nhân";
            this.rdoNhan.UseVisualStyleBackColor = true;
            // 
            // rdoChia
            // 
            this.rdoChia.AutoSize = true;
            this.rdoChia.Location = new System.Drawing.Point(35, 172);
            this.rdoChia.Name = "rdoChia";
            this.rdoChia.Size = new System.Drawing.Size(63, 24);
            this.rdoChia.TabIndex = 3;
            this.rdoChia.Text = "Chia";
            this.rdoChia.UseVisualStyleBackColor = true;
            // 
            // btnXemKetQua
            // 
            this.btnXemKetQua.BackColor = System.Drawing.Color.LightGray;
            this.btnXemKetQua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemKetQua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnXemKetQua.Location = new System.Drawing.Point(451, 263);
            this.btnXemKetQua.Name = "btnXemKetQua";
            this.btnXemKetQua.Size = new System.Drawing.Size(199, 41);
            this.btnXemKetQua.TabIndex = 3;
            this.btnXemKetQua.Text = "Xem kết quả";
            this.btnXemKetQua.UseVisualStyleBackColor = false;
            this.btnXemKetQua.Click += new System.EventHandler(this.btnXemKetQua_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(291, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "KẾT QUẢ LÀ";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(451, 357);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(199, 22);
            this.txtKetQua.TabIndex = 0;
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnXemKetQua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSoThuHai);
            this.Controls.Add(this.txtSoThuNhat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai2";
            this.Text = "Siêu máy tính Tấn Long";
            this.Load += new System.EventHandler(this.frmBai2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoThuNhat;
        private System.Windows.Forms.TextBox txtSoThuHai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoNhan;
        private System.Windows.Forms.RadioButton rdoTru;
        private System.Windows.Forms.RadioButton rdoCong;
        private System.Windows.Forms.RadioButton rdoChia;
        private System.Windows.Forms.Button btnXemKetQua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKetQua;
    }
}