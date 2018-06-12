using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el numero a contar");
            string stop = Console.ReadLine();
            for(int x = 0; x < 100; x++)
            {
                Console.WriteLine(x);
                if(x == int.Parse(stop))
                {
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
