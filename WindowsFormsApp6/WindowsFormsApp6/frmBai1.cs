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
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }


        private void Them(SanPham sp)
        {
            ListViewItem thongTin = new ListViewItem(sp.MaSanPham);
            thongTin.SubItems.Add(sp.TenSanPham);
            thongTin.SubItems.Add(sp.LoaiSanPham);
            thongTin.SubItems.Add(sp.NgaySanXuat.ToString("dd/MM/yyyy"));
            thongTin.SubItems.Add(sp.NamHetHan().ToString());
            listSP.Items.Add(thongTin); 

        }
        private void frmBai1_Load(object sender, EventArgs e)
        {
            SanPham sp1 = new SanPham("SP01", "Sữa Vinamilk", "Thực phẩm", new DateTime(2023, 5, 20));
            SanPham sp2 = new SanPham("SP02", "Bánh Oreo", "Thực phẩm", new DateTime(2022, 11, 10));
            SanPham sp3 = new SanPham("SP03", "Nước ngọt Pepsi", "Giải khát", new DateTime(2023, 7, 5));
            SanPham sp4 = new SanPham("SP04", "Tivi Samsung", "Điện tử", new DateTime(2021, 3, 15));
            SanPham sp5 = new SanPham("SP05", "Điện thoại iPhone", "Điện tử", new DateTime(2022, 9, 1));
            SanPham sp6 = new SanPham("SP06", "Bánh Mì Kinh Đô", "Thực phẩm", new DateTime(2023, 1, 18));
            SanPham sp7 = new SanPham("SP07", "Sữa TH True Milk", "Thực phẩm", new DateTime(2022, 12, 25));
            SanPham sp8 = new SanPham("SP08", "Máy giặt LG", "Điện tử", new DateTime(2021, 8, 30));
            SanPham sp9 = new SanPham("SP09", "Laptop Dell", "Điện tử", new DateTime(2022, 4, 10));
            SanPham sp10 = new SanPham("SP10", "Coca Cola", "Giải khát", new DateTime(2023, 6, 1));

            Them(sp1);
            Them(sp2);
            Them(sp3);
            Them(sp4);
            Them(sp5);
            Them(sp6);
            Them(sp7);
            Them(sp8);
            Them(sp9);
            Them(sp10);
        }

    }
}
