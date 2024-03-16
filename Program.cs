using System.Security.Cryptography.X509Certificates;

namespace module4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int i = 0;
            while (true)
            {
                
                if (i < arr.Length-1)
                {
                    if (arr[i] > arr[i+1])
                    {
                        int x = arr[i + 1];
                        arr[i+1] = arr[i];
                        arr[i] = x;
                        i = 0 ;
                    }
                     else i++; 
                }

                if (i == arr.Length - 2  && arr[i] > arr[i+1])
                {
                    int x = arr[i + 1];
                    arr[i + 1] = arr[i];
                    arr[i] = x;
                    break;
                }
            }
            foreach (var a in arr)
            {
                Console.Write(a + " ");
            }

        }
    }
}