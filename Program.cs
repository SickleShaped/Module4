using System.Security.Cryptography.X509Certificates;

namespace module4
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();

            for(int i = name.Length-1; i>=0; i--)
            {
                Console.Write(name[i]+" ");
            }

        }
    }
}