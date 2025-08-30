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
    public partial class frmBai3 : Form
    {
        List<string> list = new List<string>(); 
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnThemTuMoi_Click(object sender, EventArgs e)
        {
            var tu = txtTuMoi.Text;
            var nghia = txtNghiaCuaTu.Text;
            listBoxDSTM.Items.Add(tu);
            list.Add(nghia);
            txtTuMoi.Focus();
            txtTuMoi.Text = "";
            txtNghiaCuaTu.Text = "";
            listBoxDSTM.SelectedIndex = listBoxDSTM.Items.Count - 1;
            txtHienThiNghiaCuaTu.Text = nghia;
        }

        private void listBoxDSTM_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stt = listBoxDSTM.SelectedIndex;
            txtHienThiNghiaCuaTu.Text = list[stt];
        }
    }
}
