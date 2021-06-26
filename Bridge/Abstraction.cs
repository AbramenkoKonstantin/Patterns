using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Abstraction
    {
        protected IImplementor implementor;

        public Abstraction() { }
        public void SetImplementor(IImplementor implementor)
        {
            this.implementor = implementor;
        }
        public void Operation()
        {
            implementor.Operation();
        }
    }
}
