using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ho, ten;
            XuLyChuoiVaSo.ChaoHoi(txtNhapHoTen.Text, out ho, out ten);
            if (rdNam.Checked)
            {
                lblThongBaoChao.Text = $"Chào ông {ten}";
            }
            else if (rdNu.Checked)
            {
                lblThongBaoChao.Text = $"Chào bà {ten}";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int m = int.Parse(txtM.Text);   
            int n = int.Parse(txtN.Text);
            lblKetQua.Text = XuLyChuoiVaSo.USCLN(m, n).ToString();
        }
    }
}
