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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void frmBai2_Load(object sender, EventArgs e)
        {

        }

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            double so1 = double.Parse(txtSoThuNhat.Text);
            double so2 = double.Parse(txtSoThuHai.Text);
            double kq = 0;
            if(rdoCong.Checked)
            {
                kq = so1 + so2;
            }
            else if(rdoTru.Checked)
            {
                kq = so1 - so2;
            }
            else if(rdoNhan.Checked)
            {
                kq = so1 * so2;
            }
            else if(rdoChia.Checked)
            {
                if(so2 ==0)
                {
                    MessageBox.Show("Không thể chia cho 0!");
                    return;
                }
                kq = so1 / so2;
            }
            txtKetQua.Text=kq.ToString("N0");
        }
    }
}
