using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class GoToGymStrategy : IStrategy
    {
        public override void Use()
        {
            GoOut(); GoToBusStop(); Arrive(); DoExercises();
        }
    }
}
