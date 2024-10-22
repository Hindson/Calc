using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Multiplication : IMultiplication
    {
        public double Multiply(double a, double b)
        {
            return a * b;
        }
    }
}
