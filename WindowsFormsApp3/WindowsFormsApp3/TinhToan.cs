using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    internal class TinhToan
    {
        public static void CongHaiSo(int a, int b, ref int sum)
        {
            sum = a + b;
        }
        public static int TongDaySo(int n)
        {
            return n * (n + 1) / 2;
        }
    }
}
