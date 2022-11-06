namespace Lesson_Methods
{
    internal class Program
    {

        static string ShowColor(string username, int userage)
        {
            Console.WriteLine("{0}, {1} \nНапишите свой любимый цвет на английском с маленькой буквы", username, userage);
            var color = Console.ReadLine();
            return color;
            //switch (color)
            //{
            //    case "red":
            //        Console.BackgroundColor = ConsoleColor.Red;
            //        Console.ForegroundColor = ConsoleColor.Black;

            //        Console.WriteLine("Your color is red!");
            //        break;

            //    case "green":
            //        Console.BackgroundColor = ConsoleColor.Green;
            //        Console.ForegroundColor = ConsoleColor.Black;

            //        Console.WriteLine("Your color is green!");
            //        break;
            //    case "cyan":
            //        Console.BackgroundColor = ConsoleColor.Cyan;
            //        Console.ForegroundColor = ConsoleColor.Black;

            //        Console.WriteLine("Your color is cyan!");
            //        break;
            //    default:
            //        Console.BackgroundColor = ConsoleColor.Yellow;
            //        Console.ForegroundColor = ConsoleColor.Red;

            //        Console.WriteLine("Your color is yellow!");
            //        break;
            //}
        }


        public static void Main(string[] args)
        {

            var (name, age) = ("Евгения", 27);

            //Console.WriteLine("Мое имя: {0}", name);
            //Console.WriteLine("Мой возраст: {0}", age);

            //Console.Write("Введите имя: ");
            //name = Console.ReadLine();
            //Console.Write("Введите возрас с цифрами:");
            //age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Ваше имя: {0}", name);
            //Console.WriteLine("Ваш возраст: {0}", age);

            //ShowColor();

            //(string name, int age) anketa;

            //Console.Write("Введите имя: ");
            //anketa.name = Console.ReadLine();
            //Console.Write("Введите возраст с цифрами: ");
            //anketa.age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Ваше имя: {0}", anketa.name);
            //Console.WriteLine("Ваш возраст: {0}", anketa.age);

            //var favcolors = new string[3];
            //for (int i = 0; i < favcolors.Length; i++)
            //{
            //    favcolors[i] = ShowColor(anketa.name, anketa.age);
            //}
            //Console.WriteLine("Ваши любимые цвета: ");
            //foreach (var color in favcolors)
            //{
            //    Console.WriteLine(color);
            //}

            //Console.ReadKey();

            //int num = 5;
            //var array = GetArrayFromConsole(ref num);
            //ShowArray(array, true);
            //Console.WriteLine(age);
            //ChangeAge(age);
            //Console.WriteLine(age);

            //Console.WriteLine(name);
            //GetName(ref name);
            //Console.WriteLine(name);

            var array = GetArrayFromConsole(5);
            var sortdesc = array;
            var sortasc = array;
            SortArray(array, out sortdesc, out sortasc);


        }


        static int[] GetArrayFromConsole(int num = 5)
        {
            
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
                     
            return result ;
        }


        static void SortArray(in int[] array, out int[] sorteddesc, out int[] sortedasc)
        {

            sorteddesc = SortArrayDesc(array);
            sortedasc = SortArrayAsc(array);


        }

        static int[] SortArrayAsc(int[] result)
        {

            for (int i = 0; i <= result.Length - 1; i++)
            {
                int k = 0;
                for (int j = i; j <= result.Length - 1; j++)
                {
                    if (result[i] > result[j])
                    {
                        k = result[j];
                        result[j] = result[i];
                        result[i] = k;
                    }
                }
            }

            for (int f = 0; f < result.Length; f++)
            {
                Console.WriteLine(result[f]);
            }

            return result;
        }

        static int[] SortArrayDesc(int[] result)
        {

            for (int i = 0; i <= result.Length - 1; i++)
            {
                int k = 0;
                for (int j = i; j <= result.Length - 1; j++)
                {
                    if (result[i] < result[j])
                    {
                        k = result[j];
                        result[j] = result[i];
                        result[i] = k;
                    }
                }
            }

            for (int f = 0; f < result.Length; f++)
            {
                Console.WriteLine(result[f]);
            }

            return result;
        }

        //static void ShowArray(int[] result, bool sort = false)
        //{
        //    var temp = result;
        //    if (sort == true)
        //    {
        //       temp = SortArray(result);
        //    }

        //    for (var i = 0; i < temp.Length; i++)
        //    {
        //        Console.WriteLine(temp[i]);
        //    }
        //}

        static void ChangeAge(int age)
        {
            Console.WriteLine("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
        }

        static void GetName(ref string name)
        {
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
        }
    }
}