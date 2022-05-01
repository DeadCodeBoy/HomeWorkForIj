using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество золота");
            int gold = Convert.ToInt32(Console.ReadLine());
            int cristallPrice = 5;
            Console.WriteLine("Сколько кристаллов вы хотите купить, при цене {0} золота за один кристалл",cristallPrice);
            int purchaseAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вы успешно купили {0} кристаллов", purchaseAmount);
            gold = gold- (purchaseAmount*cristallPrice);
            Console.WriteLine("Золота у вас осталось {0}", gold);


        }
    }
}
