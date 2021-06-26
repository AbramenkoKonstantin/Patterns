using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public abstract class IStrategy
    {
        public abstract void Use();
        protected void WakeUp() { Console.WriteLine("Wake up."); }
        protected void Shower() { Console.WriteLine("Take shower."); }
        protected void Dress() { Console.WriteLine("Dress."); }
        protected void GoToBusStop() { Console.WriteLine("Go to bus stop."); }
        protected void Wait() { Console.WriteLine("Wait."); }
        protected void Arrive() { Console.WriteLine("Arrive."); }
        protected void DoWork() { Console.WriteLine("Do work."); }
        protected void DoExercises() { Console.WriteLine("Do exercises."); }
        protected void Walk() { Console.WriteLine("Walk."); }
        protected void GoOut() { Console.WriteLine("Go out."); }
        protected void GoToPark() { Console.WriteLine("Go to park."); }
    }
}
