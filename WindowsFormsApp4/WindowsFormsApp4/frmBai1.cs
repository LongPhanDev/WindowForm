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
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }
        private void Them(ThietBi tb)
        {
            ListViewItem thongTin = new ListViewItem(tb.MaThietBi);
            thongTin.SubItems.Add(tb.TenThietBi);
            thongTin.SubItems.Add(tb.NuocSanXuat);
            thongTin.SubItems.Add(tb.DonGia.ToString("N0"));
            thongTin.SubItems.Add(tb.SoLuong.ToString());
            thongTin.SubItems.Add(tb.ThanhTien().ToString("N0"));
            listView1.Items.Add(thongTin);
        }
        private void frmBai1_Load(object sender, EventArgs e)
        {
            ThietBi tb1 = new ThietBi("TB001", "Laptop Dell", "USA", 25000000, 2);
            ThietBi tb2 = new ThietBi("TB002", "Chuột Logitech", "Trung Quốc", 350000, 10);
            ThietBi tb3 = new ThietBi("TB003", "Bàn phím Cơ", "Đài Loan", 1200000, 5);
            ThietBi tb4 = new ThietBi("TB004", "Màn hình LG", "Hàn Quốc", 6500000, 3);
            ThietBi tb5 = new ThietBi("TB005", "USB 64GB", "Nhật Bản", 450000, 8);
            Them(tb1);
            Them(tb2);
            Them(tb3);
            Them(tb4);
            Them(tb5);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
