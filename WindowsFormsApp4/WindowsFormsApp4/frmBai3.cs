using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnThucThi1_Click(object sender, EventArgs e)
        {
            string ho=txtHo.Text.Trim();
            string ten=txtTen.Text.Trim();
            XuLyChuoiVaSo.NoiChuoi(ho, ten, out string HoTen);
            txtKQ_HoTen.Text = HoTen;
        }

        private void btnThucThi2_Click(object sender, EventArgs e)
        {
            int n =int.Parse(txtNhapN.Text.Trim());
            long ans = XuLyChuoiVaSo.GiaiThua(n);
            txtKetQua_GiaiThua.Text= ans.ToString("N0");
        }
    }
}
