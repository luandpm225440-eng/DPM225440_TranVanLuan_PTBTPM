﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225440_TranVanLuan_Pattern04_Prototype
{
    public abstract class Prototype
    {
        string id;
        // Constructor
        public Prototype(string id)
        {
            this.id = id;
        }
        // Gets id
        public string Id
        {
            get { return id; }
        }
        public abstract Prototype Clone();
    }
}
