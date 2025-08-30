using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmBai4 : Form
    {
        public frmBai4()
        {
            InitializeComponent();
        }

        private void frmBai4_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            int So;
            for(int i = 0; i <= 10; i++)
            {
                So = rand.Next(1, 100);
                listBox1.Items.Add(So);
            }    
        }

        private void btnTimSo_Click(object sender, EventArgs e)
        {
            int soCanTim = int.Parse(txtNhapSo.Text);
            bool oke = false;
            foreach (var item in listBox1.Items)
            {
                int so = int.Parse(item.ToString());
                if(so == soCanTim)
                {
                    oke = true;
                    break;
                }
            }
            if(oke)
            {
                lblKetQua.Text = "Tìm thấy";
            }
            else
            {
                lblKetQua.Text = "Không tìm thấy";
            }
        }
    }
}
