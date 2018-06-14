using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexTypes
{
    public class Trainer
    {
        void Operate()
        {
            var dog = new Poddle();
            dog.hasSpoken += Dog_hasSpoken;
        }

        private void Dog_hasSpoken(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }

    partial class Dog
    {
        // Properties hold values
        private string _name;
        public string Name
        {
            get { return _name; }
            private set {
                _name = value;
            }
        }

        public event EventHandler hasSpoken;

        // La firma del método incluye el valor que devuelve, el acceso, y los parámetros
        public void Speak(string what = "Bark") // Se declara un valor predeterminado
        {
            // TODO 
        }

        public void Speak(int times, string what = "Bark", bool sit = true)
        {
            // TODO 
            if(hasSpoken != null)
                hasSpoken(this, EventArgs.Empty);
        }

        // Only visible by this class
        private void Foo() { }

        // Only this and derived classes
        protected void Bar() { }

        // Only visible in this assembly
        internal void Daw() { }
    }

    class Poddle: Dog
    {
        void x()
        {
            this.Speak(2, sit:true);
        }
    }
}
