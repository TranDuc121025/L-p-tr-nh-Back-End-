using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02
{
    internal class Bài_6
    {
        public static void SapXepTangDan(double[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        double temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }

    }
}
