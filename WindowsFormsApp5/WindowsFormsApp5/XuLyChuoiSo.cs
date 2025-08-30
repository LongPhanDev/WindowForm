using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    internal class XuLyChuoiSo
    {
        public static void TachChuoi(string hoten,out string s1, out string s2)
        {
            hoten = hoten.Trim();
            int idx = hoten.LastIndexOf(' ');
            if (idx > 0)
            {
                s1 = hoten.Substring(0, idx);
                s2 = hoten.Substring(idx + 1);
            }
            else
            {
                s1 = "";
                s2 = hoten;
            }
        }
        public static bool KiemTra(int n1, int n2)
        {
            return n2 == n1 + 1;
        }
    }
}
