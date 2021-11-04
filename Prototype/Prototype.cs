﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Prototype
    {
        public string Class { get; set; }
        public string State { get; set; }

        public Prototype Clone()
        {
            return MemberwiseClone() as Prototype;
        }
    }
}
