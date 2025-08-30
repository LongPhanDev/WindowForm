using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            double diemLyThuyet = double.Parse(txtDiemLyThuyet.Text);
            double diemThucHanh= double.Parse(txtDiemThucHanh.Text);

            double TrungBinhDiem = (diemLyThuyet + diemThucHanh)/ 2;
            if(diemLyThuyet<5 || diemThucHanh <5)
            {
                lblKetQuaXepLoai.Text = "Yếu";
            }
            else
            {
                if(TrungBinhDiem < 7)
                {
                    lblKetQuaXepLoai.Text = "Trung binh";
                }
                else if(TrungBinhDiem <8)
                {
                    lblKetQuaXepLoai.Text = "Khá";
                }
                else if(TrungBinhDiem <9)
                {
                    lblKetQuaXepLoai.Text = "Giỏi";
                }
                else
                {
                    lblKetQuaXepLoai.Text = "Xuất sắc";
                }
            }
        }
    }
}
