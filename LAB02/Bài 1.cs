namespace LAB02
{
    internal class Bài_1
    {
        public static int TongSoChan(int[] a, int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                    tong += a[i];
            }
            return tong;
        }

    }
}
