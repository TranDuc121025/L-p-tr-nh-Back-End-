using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02
{
    internal class Bài_5
    {
        public static void HoanVi(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

    }
}
