using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            string[] nombres = { "Miguel", "Angel", "Rodriguez" };
            string[] hermanos = new String[]{ "Erick", "David" };
            Console.WriteLine(nombres[0]);

            foreach(string hermano in hermanos)
            {
                Console.WriteLine(hermano);
            }

            string zig = "You can get what you want out of life";

            char[] charArray = zig.ToArray();

            foreach(char car in charArray)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine(prueba());
            Console.WriteLine(p.noEstatico());

            Console.ReadLine();
        }

        public static int prueba()
        {
            int a = 2;
            return a;
        }

        public string noEstatico()
        {
            return "Hola!";
        }
    }
}
