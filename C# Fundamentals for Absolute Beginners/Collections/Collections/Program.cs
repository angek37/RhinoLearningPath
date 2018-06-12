using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car();
            car1.Make = "Nissan";
            car1.Model = "Versa 2017";
            car1.VIN = "1GNSCCE06DR107959";
            car2.Make = "Chevrolet";
            car2.Model = "Equinox 2018";
            car2.VIN = "WDZPE7CC5D5800669";

            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);

            foreach(Car car in myList)
            {
                Console.WriteLine(car.Make);
            }

            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);
            Console.WriteLine(myDictionary["WDZPE7CC5D5800669"].Make);

            Car car3 = new Car()        // Distinta sintaxis para declarar un objeto con sus atributos
            {
                Make = "Volkswagen",
                Model = "New Jetta",
                VIN = "C3"
            };

            List<Car> myList2 = new List<Car>()     // La inicialización se puede simplificar
            {
                new Car { Make = "Nissan", Model = "Cutlas Supreme"},
                new Car { Make = "Chevrolet", Model = "Equinox"}
            };

            Console.ReadKey();
        }
    }

    class Car
    {
        public string VIN { set; get; }
        public string Make { set; get; }
        public string Model { set; get; }
    }

    class Book
    {
        public string Title { set; get; }
        public string Author { set; get; }
        public string ISBN { set; get; }
    }
}
