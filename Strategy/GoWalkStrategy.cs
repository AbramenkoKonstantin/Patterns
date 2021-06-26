using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class GoWalkStrategy : IStrategy
    {
        public override void Use()
        {
            GoOut(); GoToPark(); Walk();
        }
    }
}
