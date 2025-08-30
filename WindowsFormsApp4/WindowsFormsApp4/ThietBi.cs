using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    internal class ThietBi
    {
        /*
         * PHAN TẤN LONG
         * CTK47B
         * 2312679
         */
        public string MaThietBi { get; set; }   
        public string TenThietBi { get; set; }  
        public string NuocSanXuat {  get; set; }    
        public int DonGia {  get; set; }    
        public int SoLuong {  get; set; }   
        
        public ThietBi(string maThietBi, string tenThietBi,string nuocSanXuat, int donGia, int soLuong)
        {
            MaThietBi = maThietBi;
            TenThietBi = tenThietBi;    
            NuocSanXuat= nuocSanXuat;
            DonGia = donGia;
            SoLuong = soLuong;
        }
        public int ThanhTien()
        {
            return DonGia * SoLuong;
        }
        public string HienThi()
        {
            return $"Mã TB: {MaThietBi}\n" +
                   $"Tên TB: {TenThietBi}\n" +
                   $"Nước SX: {NuocSanXuat}\n" +
                   $"Đơn giá: {DonGia:N0} VNĐ\n" +
                   $"Số lượng: {SoLuong}\n" +
                   $"Thành tiền: {ThanhTien():N0} VNĐ";
        }
    }
}
