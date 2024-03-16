using System.Security.Cryptography.X509Certificates;

namespace module4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { -5, 6, 9, 1, 2, -3 };
            int natural = 0;
            foreach (var number in arr)
            {
                if (number >= 0) { natural++; }
            }

            Console.WriteLine(natural);

        }
    }
}