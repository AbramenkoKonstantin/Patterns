using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public abstract class IStrategyClient
    {
        public abstract void UseStrategy();
        public void SetStrategy(IStrategy st) { strategy = st; }
        protected IStrategy strategy;
    }
}
