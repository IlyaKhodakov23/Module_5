namespace Lesson_intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string[] Dishes) User;
            Console.WriteLine("Введите имя пользователя");
            User.Name = Console.ReadLine();
            User.Dishes = new string[5];
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("Введите любимое блюдо {0}", i);
                User.Dishes[i] = Console.ReadLine();
            }
        }
    }
}