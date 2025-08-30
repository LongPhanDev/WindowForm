using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    internal class SanPham
    {
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string LoaiSanPham { get; set; }
        public DateTime NgaySanXuat { get; set; }
        public SanPham() { }
        public int NamHetHan()
        {
            return NgaySanXuat.Year + 3;
        }
        public SanPham(string ma, string ten, string loai, DateTime nsx)
        {
            MaSanPham = ma;
            TenSanPham = ten;
            LoaiSanPham = loai;
            NgaySanXuat = nsx;
        }
        public string HienThi()
        {
            return $"Mã: {MaSanPham}, Tên: {TenSanPham}, Loại: {LoaiSanPham}, " +
                   $"Ngày SX: {NgaySanXuat.ToShortDateString()}, Hết hạn: {NamHetHan()}";
        }
    }
}
