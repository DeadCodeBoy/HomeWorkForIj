using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeForOnePeople = 10;
            Console.WriteLine("Введите количество людей в очереди");
            int numberOfPeople = Convert.ToInt32(Console.ReadLine());

            int waitHour = (numberOfPeople*timeForOnePeople)/60;
            double waitMinutes = (waitHour % 60)*10;


            Console.WriteLine("Вы должны отстоять в очереди {0} часа и {1} минут ", waitHour, waitMinutes );

        }
    }
}
