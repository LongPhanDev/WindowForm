using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    internal class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public float HeSoLuong { get; set; }    
        public float HeSoPhuCap { get; set; }   

        public NhanVien(string manv, string hoten, DateTime ngaySinh, float heSoLuong, float heSoPhuCap)
        {
            MaNV = manv;
            HoTen = hoten;
            NgaySinh = ngaySinh;
            HeSoLuong = heSoLuong;
            HeSoPhuCap= heSoPhuCap;
        }
        public float TongLuong()
        {
            return (HeSoLuong + HeSoPhuCap) * 1150000;
        }
        public string HienThi()
        {
            return $"Mã Nhân Viên:{MaNV}\n" +
                $"Tên Nhân Viên:{HoTen}\n" +
                $"Ngày sinh :{NgaySinh:dd/MM/yyyy}\n" +
                $"Hệ số lương: {HeSoLuong}\n" +
                $"Hệ số phụ cấp:{HeSoPhuCap}\n" +
                $"Tổng lương:{(TongLuong()):N0}VNĐ";
        }
    }
}
