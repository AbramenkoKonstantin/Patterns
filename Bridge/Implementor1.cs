﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Implementor1 : IImplementor
    {
        void IImplementor.Operation()
        {
            Console.WriteLine("Implementor 1");
        }
    }
}
