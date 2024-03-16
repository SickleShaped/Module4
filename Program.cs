using System.Security.Cryptography.X509Certificates;

namespace module4
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            for (int j=0; j<3; j++)
            {
                (string Name, string LastName, string Login, int LoginLength, bool HasPet, double Age, string[] favcolors) User;

                Console.WriteLine("Введите имя");
                User.Name = Console.ReadLine();

                Console.WriteLine("Введите фамилию");
                User.LastName = Console.ReadLine();

                Console.WriteLine("Введите логин");
                User.Login = Console.ReadLine();

                User.LoginLength = User.Login.Length;
                Console.WriteLine("Есть ли у вас животные? Да или Нет");
                var anwser = Console.ReadLine();
                if (anwser == "Да") { User.HasPet = true; } else { User.HasPet = false; }

                Console.WriteLine("Введите возраст");
                User.Age = Double.Parse(Console.ReadLine());

                User.favcolors = new string[3];
                Console.WriteLine("Введите три любимых цвета пользователя");
                for (int i = 0; i < 3; i++)
                {
                    User.favcolors[i] = Console.ReadLine();
                }
            }
            


        }
    }
}