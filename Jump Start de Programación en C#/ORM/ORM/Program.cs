using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new DBEntities();
            var products = context.Products; // Es posible agregar una clausula WHERE

            foreach (var product in products
                .Where(x => x.Name.Contains("o")))
            {
                Console.WriteLine(product.Name);
            }

            Console.WriteLine();

            var Prod = products.First(x => x.Name.StartsWith("c"));
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("First: {0}",Prod.Name);

            Prod.Name = "Chocoroles Marinela";

            context.SaveChanges();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;

            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
            }

            context.Products.Remove(Prod);
            context.SaveChanges();

            Console.WriteLine();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;


            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
            }

            Console.ReadKey();
        }
    }
}
