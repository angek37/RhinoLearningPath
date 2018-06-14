using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexTypes
{

    internal class BaseClass
    {
        internal virtual void Name()
        {
            // El método puede ser sustituido
            Console.WriteLine("BaseClass");
        }
    }

    internal class DerivedOverride : BaseClass
    {
        internal override void Name()
        {
            Console.WriteLine("DerivedOverride");
        }
    }

    internal class DerivedNew : BaseClass
    {
        internal new void Name()
        {
            Console.WriteLine("New");
        }
    }

    internal class DerivedOverwrite : BaseClass
    {
        internal void Name()
        {
            Console.WriteLine("OverWrite");
        }
    }

    class Program
    {
        static void Main()
        {
            var baseClass = new BaseClass();
            var derivedOverride = new DerivedOverride();
            var derivedNew = new DerivedNew();
            var derivedOverWrite = new DerivedOverwrite();

            // Llaman al método de su propia clase
            baseClass.Name();
            derivedOverride.Name();
            derivedNew.Name();
            derivedOverWrite.Name();
            Console.ReadLine();

            baseClass.Name();
            derivedOverride.Name();
            ((BaseClass)derivedNew).Name();
            ((BaseClass)derivedOverWrite).Name();
            Console.ReadLine();

            var t1 = typeof(BaseClass);
            Console.WriteLine(t1.Name);
            Console.WriteLine(t1.Assembly);
            Console.ReadLine();
        }
    }

    public struct Point
    {
        public int X { set; get; }
        public int Y { set; get; }
    }

    public class Class1
    {
        public string Name { set; get; }

        public Class1(string Name)
        {
            this.Name = Name;
        }
    }

    public class Class2 : Class1 // Class2 hereda de Class1
    {
        public int Age { set; get; }

        public Class2(string Name, int Age) : base(Name)
        {
            this.Age = Age;
        }
    }

    public class Class3 : Class2 // Class3 hereda de Class2 y termina con 3 atributos   
    {
        public string Address { set; get; }

        public Class3(string Name, int Age, string Address) : base(Name, Age)
        {
            this.Address = Address;
        }
    }

    interface IDataRecord
    {
        // Define el método
        void Save();
    }

    public class Customer : IDataRecord
    {

        // Implementa el método
        public void Save()
        {
            
        }
    }
}