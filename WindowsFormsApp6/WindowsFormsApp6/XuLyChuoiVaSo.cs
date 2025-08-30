using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    internal class XuLyChuoiVaSo
    {
        public static void ChaoHoi(string hoten, out string s1, out string s2)
        {
           //Tách lấy Name nhân vật trước
            hoten=hoten.Trim();
            int idx = hoten.LastIndexOf(' ');
            if(idx >0)
            {   s1= hoten.Substring(0,idx);
                s2 =hoten.Substring(idx + 1);   
            }
            else
            {
                s1 = "";
                s2 = hoten;
            }
        }
        public static int USCLN(int m, int n)
        {
            while(n!=0)
            {
                int tmp = n;
                n = m % n;
                m = tmp;
            }
            return m;
        }
    }
}
