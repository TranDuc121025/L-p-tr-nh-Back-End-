using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    internal class Bài_7
    {
            static void Main()
            {
                Console.Write("Nhập năm: ");
                int nam = int.Parse(Console.ReadLine());

                if ((nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0)
                    Console.WriteLine("Đây là năm nhuận.");
                else
                    Console.WriteLine("Đây không phải là năm nhuận.");
            }
        }
    }
