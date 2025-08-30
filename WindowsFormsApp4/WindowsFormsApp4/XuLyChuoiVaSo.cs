using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    internal class XuLyChuoiVaSo
    {
        /*
         * PHAN TẤN LONG
         * CTK47B
         * 2312679
         */
        //Hàm tĩnh xử lý nối chuỗi
        public static void NoiChuoi(string ho, string ten, out string s)
        {
            s = ho.Trim() + " " + ten.Trim();
        }
        //Hàm tĩnh tính toán giai thừa
        public static long  GiaiThua(int n)
        {
            int i;
            long ans = 1;
            if(n ==0 || n == 1)
            {
                return ans;
            }
            else
            {
                for(i = 2; i <= n; i++)
                {
                    ans *= i;
                }
                return ans;
            }
        }
    }
}
