using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    internal class Bài_8
    {
        static void Main()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"\nBảng cửu chương {i}:");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
            }
        }
    }
}
