using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Model
{
    class Generator
    {
        public static string GeraLetras(string x, string y)
        {
            Random ran = new Random();
            int r = ran.Next(1, 3);
            if (r == 1)
            {
                return x;
            }
            else
            {
                return y;
            }
        }
        public static string GeraLetra2(string x, string y, string z)
        {
            Random ran = new Random();
            int r = ran.Next(1, 4);
            if (r == 1)
            {
                return x;
            }
            else if (r == 2)
            {
                return y;
            }
            else
            {
                return z;
            }
        }
    }
}
