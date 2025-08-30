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
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            var Form = new frmBai1();
            Form.ShowDialog();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            var Form = new frmBai2();
            Form.ShowDialog();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            var Form = new frmBai3();
            Form.ShowDialog();
        }
    }
}
