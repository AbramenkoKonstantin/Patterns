using System;
namespace Prototype
{
    class CloneClass
    {
        public int X { get; set; }
        public int Y { get; set; }
        public DeepStructure ds;
        public CloneClass()
        {
            ds = new DeepStructure();
        }
        public override string ToString()
        {
            return
            X.ToString() + " " +
            Y.ToString() + " " +
            ds.A.ToString() + " " +
            ds.B.ToString() + " " +
            ds.GetHashCode();

        }
    }
}
