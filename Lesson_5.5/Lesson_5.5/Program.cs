namespace Lesson_5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Напишите что-то");
            //var str = Console.ReadLine();

            //Console.WriteLine("Укажите глубину эха");
            //var deep = Convert.ToInt32(Console.ReadLine());

            //Echo(str, deep);

            //Console.Write(Factorial(deep));

            var S = PowerUp(2, 4);
            Console.WriteLine(S);
        }

        static void Echo(string phrase, int deep)
        {
            var modif = phrase;

            if (modif.Length > 2)
            {
                modif = modif.Remove(0,2);
            }

            Console.BackgroundColor = (ConsoleColor)deep;

            Console.WriteLine(modif);

            if (deep > 1)
            {
                Echo(modif, deep - 1);
            }
        }

        static long Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }

        private static int PowerUp(int N, byte pow)
        {
            if (pow == 0)
            {
                return 1;
            }

            else
            {
                if (pow == 1)
                {
                    return N;
                }

                else
                {
                    return N * PowerUp(N, --pow);
                }
            }

        }

    }
}