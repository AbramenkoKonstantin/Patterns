using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class GoToWorkStrategy : IStrategy
    {
        public override void Use()
        {
            WakeUp(); Shower(); Dress(); GoOut();
            GoToBusStop(); Wait(); Arrive(); DoWork();
        }
    }
}
