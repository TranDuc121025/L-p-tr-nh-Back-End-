using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    internal class Bài_9
    {
            static void Main()
            {
                Console.Write("Nhập số nguyên dương: ");
                int n = int.Parse(Console.ReadLine());

                long giaithua = 1;
                for (int i = 1; i <= n; i++)
                {
                    giaithua *= i;
                }

                Console.WriteLine($"Giai thừa của {n} là: {giaithua}");
            }
        }
    }
