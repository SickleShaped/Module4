using System.Security.Cryptography.X509Certificates;

namespace module4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int summ = 0;
            foreach (var item in arr)
            {
                summ += item;
            }
            Console.WriteLine(summ);

        }
    }
}