using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02
{
    internal class Bài_4
    {
        public static int TimSoLonThuHai(int[] a, int n)
        {
            int max = int.MinValue, secondMax = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                if (a[i] > max)
                {
                    secondMax = max;
                    max = a[i];
                }
                else if (a[i] > secondMax && a[i] != max)
                {
                    secondMax = a[i];
                }
            }
            return (secondMax == int.MinValue) ? -1 : secondMax; // Trả -1 nếu không tồn tại
        }

    }
}
