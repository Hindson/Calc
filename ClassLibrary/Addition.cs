﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Addition : IAddition
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
    }
}
