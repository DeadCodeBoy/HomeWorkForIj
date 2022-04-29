using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp;
            string name = "Дима";
            string lastname = "Петров";
            Console.Write(name+" ");
            Console.WriteLine(lastname);
            temp = name;
            name = lastname;
            lastname = temp;
            Console.Write(name + " ");
            Console.WriteLine(lastname);


        }
    }
}
