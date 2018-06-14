using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAndGC
{
    class Program
    {
        static void Main(string[] args)
        {
            Reflection();
            InstanceOfType();
            Property();
            Method();
            Console.ReadKey();
        }

        public static void Reflection()
        {
            var dog = new Dog { NumberOfLegs = 4 };

            // At compile time
            Type t1 = typeof(Dog);

            // At runtime
            Type t2 = dog.GetType();

            // output: Dog
            Console.WriteLine(t2.Name);

            // output: After002, Version=1.0.0.0,
            // Culture=neutral, PublicKeyToken=null
            Console.WriteLine(t2.Assembly);
        }

        public static void InstanceOfType()
        {
            var newDog =
                (Dog)Activator.CreateInstance(typeof(Dog));
            var genericDog =
                Activator.CreateInstance<Dog>();

            // uses default constructor
            // with no defined parameters
            var dogConstructor =
                typeof(Dog).GetConstructors()[0];

            var advancedDog =
                (Dog)dogConstructor.Invoke(null);
            
        }

        public static void Property()
        {
            var horse = new Animal() { Name = "Ed" };

            var type = horse.GetType();

            var property = type.GetProperty("Name");

            var value = property.GetValue(horse, null);

            Console.WriteLine(value);
        }

        public static void Method()
        {
            var horse = new Animal();

            var type = horse.GetType();

            var method = type.GetMethod("Speak");

            var value = (string)method.Invoke(horse, null);

            Console.WriteLine(value);

            value = null;

            GC.Collect();
        }
    }

    public class Dog
    {
        public int NumberOfLegs { set; get; }
        public Dog()
        {
            NumberOfLegs = 4;
        }

        public Dog(int NumberOfLegs)
        {
            this.NumberOfLegs = NumberOfLegs;
        }
    }

    public class Animal
    {
        public string Name { set; get; }
        public string Speak() { return "Hello"; }
    }
}
