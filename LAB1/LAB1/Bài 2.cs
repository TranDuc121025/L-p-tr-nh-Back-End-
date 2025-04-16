//Bài 1
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Nhập tên của bạn: ");
//        string ten = Console.ReadLine();

//        Console.Write("Nhập tuổi của bạn: ");
//        int tuoi = int.Parse(Console.ReadLine());

//        Console.WriteLine($"Xin chào {ten}, bạn {tuoi} tuổi!");
//    }
//}

//Bài 2
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Nhập chiều dài: ");
//        double dai = double.Parse(Console.ReadLine());

//        Console.Write("Nhập chiều rộng: ");
//        double rong = double.Parse(Console.ReadLine());

//        double dientich = dai * rong;
//        Console.WriteLine($"Diện tích hình chữ nhật là: {dientich}");
//    }
//}

//Bài 3
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Nhập nhiệt độ (C): ");
//        double c = double.Parse(Console.ReadLine());

//        double f = (c * 9 / 5) + 32;
//        Console.WriteLine($"Nhiệt độ tương ứng (F): {f}");
//    }
//}

//Bài 4
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Nhập một số nguyên: ");
//        int n = int.Parse(Console.ReadLine());

//        if (n % 2 == 0)
//            Console.WriteLine("Đây là số chẵn.");
//        else
//            Console.WriteLine("Đây là số lẻ.");
//    }
//}

//Bài 5
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Nhập số thứ nhất: ");
//        double a = double.Parse(Console.ReadLine());

//        Console.Write("Nhập số thứ hai: ");
//        double b = double.Parse(Console.ReadLine());

//        double tong = a + b;
//        double tich = a * b;

//        Console.WriteLine($"Tổng = {tong}, Tích = {tich}");
//    }
//}

//Bài 6 
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Nhập một số: ");
//        double n = double.Parse(Console.ReadLine());

//        if (n > 0)
//            Console.WriteLine("Đây là số dương.");
//        else if (n < 0)
//            Console.WriteLine("Đây là số âm.");
//        else
//            Console.WriteLine("Đây là số 0.");
//    }
//}

//Bài 7
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Nhập năm: ");
//        int nam = int.Parse(Console.ReadLine());

//        if ((nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0)
//            Console.WriteLine("Đây là năm nhuận.");
//        else
//            Console.WriteLine("Đây không phải là năm nhuận.");
//    }
//}

//Bài 8
//using System;

//class Program
//{
//    static void Main()
//    {
//        for (int i = 1; i <= 10; i++)
//        {
//            Console.WriteLine($"\nBảng cửu chương {i}:");
//            for (int j = 1; j <= 10; j++)
//            {
//                Console.WriteLine($"{i} x {j} = {i * j}");
//            }
//        }
//    }
//}

//Bài 9
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Nhập số nguyên dương: ");
//        int n = int.Parse(Console.ReadLine());

//        long giaithua = 1;
//        for (int i = 1; i <= n; i++)
//        {
//            giaithua *= i;
//        }

//        Console.WriteLine($"Giai thừa của {n} là: {giaithua}");
//    }
//}

//Bài 10
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Nhập một số nguyên: ");
//        int n = int.Parse(Console.ReadLine());
//        bool laNguyenTo = true;

//        if (n < 2)
//        {
//            laNguyenTo = false;
//        }
//        else
//        {
//            for (int i = 2; i <= Math.Sqrt(n); i++)
//            {
//                if (n % i == 0)
//                {
//                    laNguyenTo = false;
//                    break;
//                }
//            }
//        }

//        if (laNguyenTo)
//            Console.WriteLine($"{n} là số nguyên tố.");
//        else
//            Console.WriteLine($"{n} không phải là số nguyên tố.");
//    }
//}
