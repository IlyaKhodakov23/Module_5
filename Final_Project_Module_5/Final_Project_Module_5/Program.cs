using System.Drawing;
using System.Xml.Linq;

namespace Final_Project_Module_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserData();
        }

        static void UserData()
        {
            (string name, string lastname, int age, bool ispet, int Npet, string[] petNames, int ColorCount, string[] colours) user;
            Console.WriteLine("Введите имя: ");
            user.name = Console.ReadLine();
            Console.WriteLine("Введите фамилию: ");
            user.lastname = Console.ReadLine();
            Console.WriteLine("Введите возраст: ");
            user.age = Convert.ToInt32(Console.ReadLine());
            bool checking = check(user.age);
            while (! checking) 
            {
                Console.WriteLine("Попробуйте ввести возраст еще раз, он должен быть больше 0: ");
                user.age = Convert.ToInt32(Console.ReadLine());
                checking = check(user.age);
            }
            user.ispet = false;
            user.Npet = 0;
            user.petNames = new string[0];
            Console.WriteLine("У вас есть питомец? Да/Нет.");
            string answer = Console.ReadLine();
            if (answer == "Да")
            {
                user.ispet = true;
                Console.WriteLine("Введите количество питомцев: ");
                user.Npet = Convert.ToInt32(Console.ReadLine());
                checking = check(user.Npet);
                while (!checking)
                {
                    Console.WriteLine("Попробуйте ввести количество питомцев еще раз, оно должно быть больше 0: ");
                    user.Npet = Convert.ToInt32(Console.ReadLine());
                    checking = check(user.Npet);
                }
                user.petNames = new string[user.Npet];
                user.petNames = NamesPets(user.Npet);
            }    
            else user.ispet = false;
            Console.WriteLine("Введите количество любимых цветов: ");
            user.ColorCount = Convert.ToInt32(Console.ReadLine());
            checking = check(user.ColorCount);
            while (!checking)
            {
                Console.WriteLine("Попробуйте ввести количество цветов еще раз, оно должно быть ,больше 0: ");
                user.ColorCount = Convert.ToInt32(Console.ReadLine());
                checking = check(user.ColorCount);
            }
            user.colours = new string[user.ColorCount];
            user.colours = LikeColours(user.ColorCount);

            ShowDatas(user.name, user.lastname, user.age, user.ispet, user.Npet, user.petNames, user.ColorCount, user.colours);
        }

        static string[] NamesPets(int countPets)
        {
            string[] arr = new string[countPets];
            for (int i = 0; i < countPets; i++)
            {
                Console.WriteLine("Введите имя питомца #{0}", i + 1);
                arr[i] = Console.ReadLine();
            }
            return arr;
        }

        static string[] LikeColours(int count)
        {
            string[] colourarr = new string[count];
            for (int i = 0; i<count; i++)
            {
                Console.WriteLine("Напишите любимый цвет #{0}", i + 1);
                colourarr[i] = Console.ReadLine();
            }
            return colourarr;
        }

        static bool check(int num)
        {
            if (num > 0) return true;
            else return false;
        }

        static void ShowDatas (string name, string lastname, int age, bool ispet, int Npet, string[] petNames, int ColorCount, string[] colours)
        {
            Console.WriteLine("Имя пользователя: {0}", name);
            Console.WriteLine("Фамилия пользователя: {0}", lastname);
            Console.WriteLine("Возраст пользователя: {0}", age);
            string answ;
            if (ispet == true)
            {
                answ = "Да";
                Console.WriteLine("Наличие питомца: {0}", answ);
                Console.WriteLine("Количество питомцев: {0}", Npet);
                Console.WriteLine("Имена питомца(-ев): ");
                for (int i = 0; i < Npet; i++)
                {
                    Console.WriteLine(petNames[i]);
                }
            }
            else
            {
                answ = "Нет";
                Console.WriteLine("Наличие питомца: {0}", answ);
                Npet = 0;
            }
            Console.WriteLine("Количество любимых цветов: {0}", ColorCount);
            Console.WriteLine("Любимые цвета: ");
            for (int i =0; i < Npet; i++)
            {
                Console.WriteLine(colours[i]);
            }
        }

    }

}