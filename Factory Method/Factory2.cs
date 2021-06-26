using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class Factory2 : Factory
    {
        public override BaseClass FactoryMethod()
        {
            return new DerivedClass2();
        }
    }
}
