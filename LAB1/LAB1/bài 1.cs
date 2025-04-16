using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    internal class bài_1
    {
        static void Main()
        {
            Console.Write("Nhập tên của bạn: ");
            string ten = Console.ReadLine();

            Console.Write("Nhập tuổi của bạn: ");
            int tuoi = int.Parse(Console.ReadLine());

            Console.WriteLine($"Xin chào {ten}, bạn {tuoi} tuổi!");
        }
    }
}