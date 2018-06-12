using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>() {
                new Car() { VIN="A1", Make = "BMW", Model= "550i", StickerPrice=55000, Year=2009},
                new Car() { VIN="B2", Make="Toyota", Model="4Runner", StickerPrice=35000, Year=2010},
                new Car() { VIN="C3", Make="BMW", Model = "745li", StickerPrice=75000, Year=2008},
                new Car() { VIN="D4", Make="Ford", Model="Escape", StickerPrice=25000, Year=2008},
                new Car() { VIN="E5", Make="BMW", Model="55i", StickerPrice=57000, Year=2010}
            };

            //var bmws = from car in myCars
            //           where car.Make == "BMW"
            //           && car.Year == 2010
            //           select car;


            //var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);

            //var bmws = from car in myCars
            //           orderby car.Year descending
            //           select car;

            //var bmws = myCars.OrderBy(p => p.Year);

            //Console.WriteLine(bmws.GetType());
            //foreach (Car bmw in bmws)
            //{
            //    Console.WriteLine("{1} {0}", bmw.Model, bmw.Year);
            //}

            //var firstBMW = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "BMW");
            //Console.WriteLine(firstBMW.VIN);

            myCars.ForEach(p => p.StickerPrice -= 3000);
            myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));

            Console.WriteLine("{0:C}", myCars.Sum(p => p.StickerPrice));



            Console.ReadKey();
        }

        class Car
        {
            public string VIN { set; get; }
            public string Make { set; get; }
            public string Model { set; get; }
            public int Year { set; get; }
            public double StickerPrice { set; get; }
        }
    }
}