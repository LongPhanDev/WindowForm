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
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void listNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Them(NhanVien nv)
        {
            ListViewItem thongTin = new ListViewItem(nv.MaNV);
            thongTin.SubItems.Add(nv.HoTen);
            thongTin.SubItems.Add(nv.NgaySinh.ToString("dd/MM/yyyy"));
            thongTin.SubItems.Add(nv.HeSoLuong.ToString());
            thongTin.SubItems.Add(nv.HeSoPhuCap.ToString());
            thongTin.SubItems.Add(nv.TongLuong().ToString("N0"));
            listNV.Items.Add(thongTin); 
        }
        private void frmBai1_Load(object sender, EventArgs e)
        {
            NhanVien nv1 = new NhanVien("NV01", "Phan Văn Giang", new DateTime(2002, 4, 30), 2.5f, 0.5f);
            NhanVien nv2 = new NhanVien("NV02", "Trần Thị Lan Hương", new DateTime(2005, 1, 1), 2.5f, 2.25f);
            NhanVien nv3 = new NhanVien("NV03", "John Cena", new DateTime(1999, 12, 20), 4.5f, 1.5f);
            NhanVien nv4 = new NhanVien("NV04", "Giáp Văn Cương", new DateTime(2001, 6, 15), 3.0f, 1.0f);
            NhanVien nv5 = new NhanVien("NV05", "Ngô Thị Hạnh", new DateTime(2000, 11, 3), 2.2f, 0.8f);
            NhanVien nv6 = new NhanVien("NV06", "Nguyễn Ngọc Lâm", new DateTime(1998, 7, 22), 3.8f, 1.2f);
            NhanVien nv7 = new NhanVien("NV07", "Hoàng Thị Mai", new DateTime(2003, 2, 14), 2.7f, 1.5f);
            NhanVien nv8 = new NhanVien("NV08", "Mai Hoàng", new DateTime(1979, 9, 9), 4.0f, 1.0f);
            NhanVien nv9 = new NhanVien("NV09", "Phan Thị Thúy Quỳnh", new DateTime(2004, 5, 5), 2.1f, 0.6f);
            NhanVien nv10 = new NhanVien("NV10", "Michael Jordan", new DateTime(2001, 8, 30), 3.5f, 2.0f);
            Them(nv1);
            Them(nv2);
            Them(nv3);
            Them(nv4);
            Them(nv5);
            Them(nv6);
            Them(nv7);
            Them(nv8);
            Them(nv9);
            Them(nv10);
        }
    }
}
