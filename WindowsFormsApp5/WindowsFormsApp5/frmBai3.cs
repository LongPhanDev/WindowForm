using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ho, ten;
            XuLyChuoiSo.TachChuoi(txtHoTen.Text, out ho, out ten);
            lblHo.Text = ho;
            lblTen.Text = ten;  
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtSo1.Text);
            int n2 = int.Parse(txtSo2.Text);
            bool kq = XuLyChuoiSo.KiemTra(n1, n2);
            lblKiemTra.Text=kq.ToString();
        }
    }
}
