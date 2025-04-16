using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    internal class Bài_3
    {
            static void Main()
            {
                Console.Write("Nhập nhiệt độ (C): ");
                double c = double.Parse(Console.ReadLine());

                double f = (c * 9 / 5) + 32;
                Console.WriteLine($"Nhiệt độ tương ứng (F): {f}");
            }
        }
    }
