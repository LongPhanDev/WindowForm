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
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void tsmiBai1_Click(object sender, EventArgs e)
        {
            var Form = new frmBai1();
            Form.ShowDialog();
        }

        private void tsmiBai2_Click(object sender, EventArgs e)
        {
            var Form = new frmBai2();
            Form.ShowDialog();
        }

        private void tsmiBai3_Click(object sender, EventArgs e)
        {
            var Form = new frmBai3();
            Form.ShowDialog();  
        }

        private void bài4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new frmBai4();   
            Form.ShowDialog();
        }
    }
}
