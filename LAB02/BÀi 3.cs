using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02
{
    internal class BÀi_3
    {
        public static void DemSoAmDuong(int[] a, int n, out int demAm, out int demDuong)
        {
            demAm = 0;
            demDuong = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] < 0) demAm++;
                else if (a[i] > 0) demDuong++;
            }
        }

    }
}
