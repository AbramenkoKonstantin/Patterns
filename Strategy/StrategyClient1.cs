using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class StrategyClient1 : IStrategyClient
    {
        public StrategyClient1() { }
        public override void UseStrategy()
        {
            strategy.Use();
        }
    }
}
