using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как вас зовут ?");
            string name = Console.ReadLine();
            Console.WriteLine("Сколько вам лет ?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Какой ваш знак зодиака ?");
            string zodiak = Console.ReadLine();
            Console.WriteLine("Где вы работаете ?");
            string work = Console.ReadLine();
            Console.WriteLine("Вас зовут {0}, вам {1} лет, вы {2} и работаете {3}", name, age, zodiak, work);

        }
    }
}
