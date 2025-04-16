using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    internal class Bài_4
    {
            static void Main()
            {
                Console.Write("Nhập một số nguyên: ");
                int n = int.Parse(Console.ReadLine());

                if (n % 2 == 0)
                    Console.WriteLine("Đây là số chẵn.");
                else
                    Console.WriteLine("Đây là số lẻ.");
            }
        }
    }