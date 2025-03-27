namespace LAB_9
{
    internal class Program
    {
        private class User
        {
            public string Name { get; set; }
        }

        private static void Main(string[] args)
        {
            var user = new User() { Name = "Aaaa" };

            int[] arr = { 2, 1, 3, 5, 9, 6, 2 };
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        var tmp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = tmp;
                    }

            //int[] arr = { 9, 2, 4, 1, 2, 6, 11, 3, 5 };

            //Console.WriteLine(arr);
            //int n = arr.Length;
            //var str = string.Join(',', arr);

            //Console.WriteLine(str);

            //foreach (int i in arr)
            //{
            //    Console.Write($"{i},");
            //}
        }
    }
}