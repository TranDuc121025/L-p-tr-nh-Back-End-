using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    internal class Bài_6
    {
            static void Main()
            {
                Console.Write("Nhập một số: ");
                double n = double.Parse(Console.ReadLine());

                if (n > 0)
                    Console.WriteLine("Đây là số dương.");
                else if (n < 0)
                    Console.WriteLine("Đây là số âm.");
                else
                    Console.WriteLine("Đây là số 0.");
            }
        }
    }
