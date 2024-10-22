using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Division : IDivision
    {
        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero");
            return a / b;
        }
    }
}
