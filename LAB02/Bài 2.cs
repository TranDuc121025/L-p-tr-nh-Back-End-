namespace LAB02
{
    internal class Bài_2
    {
        public static bool LaSoNguyenTo(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }

        public static void HienThiSoNguyenTo(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (LaSoNguyenTo(a[i]))
                    Console.WriteLine($"a[{i}] = {a[i]} là số nguyên tố");
            }
        }

    }
}
