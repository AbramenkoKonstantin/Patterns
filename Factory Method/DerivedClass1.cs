using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class DerivedClass1 : BaseClass
    {
        public override string GetName()
        {
            return "Derived Class 1";
        }
    }
}
