namespace LAB_5
{
    public static class Math
    {
        // 5! = 5 * 4 *3 *2 * 1;
        // 3! = 3 * 2 *1;
        // x! = x * (x-1) * (x-2) * ... * 1;
        
        // 1! = 1 * (1-1) = 1
        public static int Factorical(int a)
        {
            Sum("sadsajdiasj", 2, 3, 3, 6, 2, 12, 23, 321, 23, 2312, 2312, 2312);
            if (a == 1 || a == 0)
            {
                return 1;
            }

            return a * Factorical(a - 1);
        }

        public static int Sum(string a, int b, params int[] mas)
        {
            return mas.Sum();
        }
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
        public static int Sum(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
        public static double Sum(double a, double b)
        {
            return a + b;
        }
    }
}
