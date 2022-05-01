using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int picturesInLine = 3;
            int allPictures = 52;
            int maxOflines = allPictures / picturesInLine;
            int lostPictures = allPictures % picturesInLine;
            Console.WriteLine("полностью заполненных рядов можно вывести {0}, картинок сверх меры {1}", maxOflines, lostPictures);


        }
    }
}
