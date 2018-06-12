using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.Make = "Oldmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";

            Car myOtherCar = myCar;

            Console.WriteLine("{0} {1} {2} {3}",
                myOtherCar.Make,
                myOtherCar.Model,
                myOtherCar.Year,
                myOtherCar.Color
                );

            myOtherCar.Model = "98";


            Console.WriteLine("{0} {1} {2} {3}",
                myOtherCar.Make,
                myOtherCar.Model,
                myOtherCar.Year,
                myOtherCar.Color
                );

            myOtherCar = null;
            myCar = null;

            Console.Read();

        }
    }

    class Car
    {
        public Car()
        {
            Make = "Nissan";
        }

        public Car(string Make)
        {
            this.Make = Make;
        }

        public string Make { set; get; }
        public string Model { set; get; }
        public int Year { set; get; }
        public string Color { set; get; }
    }
}
