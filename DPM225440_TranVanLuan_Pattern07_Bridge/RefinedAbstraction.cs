﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225440_TranVanLuan_Pattern07_Bridge
{
    public class RefinedAbstraction: Abstraction
    {
        public override void Operation()
        {
            implementor.Operation();
        }
    }
}
