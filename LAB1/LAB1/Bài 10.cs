using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    internal class Bài_10
    {
            static void Main()
            {
                Console.Write("Nhập một số nguyên: ");
                int n = int.Parse(Console.ReadLine());
                bool laNguyenTo = true;

                if (n < 2)
                {
                    laNguyenTo = false;
                }
                else
                {
                    for (int i = 2; i <= Math.Sqrt(n); i++)
                    {
                        if (n % i == 0)
                        {
                            laNguyenTo = false;
                            break;
                        }
                    }
                }

                if (laNguyenTo)
                    Console.WriteLine($"{n} là số nguyên tố.");
                else
                    Console.WriteLine($"{n} không phải là số nguyên tố.");
            }
        }

}