using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    internal class bài_5
    {
            static void Main()
            {
                Console.Write("Nhập số thứ nhất: ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("Nhập số thứ hai: ");
                double b = double.Parse(Console.ReadLine());

                double tong = a + b;
                double tich = a * b;

                Console.WriteLine($"Tổng = {tong}, Tích = {tich}");
            }
        }
    }
