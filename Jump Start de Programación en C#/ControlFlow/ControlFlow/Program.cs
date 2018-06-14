using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crea una instancia de un stringbuilder
            var sb = new StringBuilder();

            // Append lines
            sb.AppendLine("This is the original first line");
            sb.AppendLine("This is another line");

            // append formatted values
            for (int i = 0; i < 10; i++)
            {
                sb.AppendFormat(
                    "Inserting line with loop index {0,5} on {1,9:d} {2}", i, DateTime.Now, Environment.NewLine);

            }

            // replace values
            sb.Replace("index", "counter");

        }
    }

    public class Animal { public int Temp { get; set; } }
    public class Dog : Animal { public string Name { get; set; } }
    public class Poddle : Dog { public string Groomer { get; set; } }

    public class y
    {
        public void x()
        {
            var animal = new Animal();
            var dog = new Dog();
            var poodle = new Poddle();

            TakeAnimal(dog);

        }

        public void TakeAnimal(Animal a)
        {
            a.Temp = 10;
            
            //var dog = a as Dog; // Otra forma de hacer cast
            var dog = (Dog)a; //Cast
            dog.Name = "Daren";

        }
    }
}
