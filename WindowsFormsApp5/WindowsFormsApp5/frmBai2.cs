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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtNhapSoN.Text);
            int ans = 0;
            if(rdTinhTong.Checked)
            {
                for(int i=1;i<=n;i++)
                {
                    ans += i;
                }
                txtKetQua.Text = ans.ToString("N0");
            }
            else if(rdTinhGiaiThua.Checked)
            {
                ans = 1;
                for(int i =2;i<=n;i++)
                {
                    ans *= i;
                }
                txtKetQua.Text=ans.ToString("N0");  
            }
        }
    }
}
