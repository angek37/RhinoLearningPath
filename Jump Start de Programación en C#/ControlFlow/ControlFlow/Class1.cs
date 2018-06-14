using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    class Class1
    {
        enum Dogs { Lassie, Snoopy, Yeller, Fido }

        void x()
        {
            var snoopy = Dogs.Snoopy;
            switch (snoopy)
            {
                case Dogs.Lassie:
                    break;
                case Dogs.Snoopy:
                    break;
                case Dogs.Yeller:
                    break;
                default: // Es opcional
                    break;
            }
        }
    }
}
