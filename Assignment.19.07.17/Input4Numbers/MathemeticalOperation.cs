using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input4Numbers
{
    class MathemeticalOperation
    {
       public double Addition(double first, double second, double third, double forth)
        {
            double addition = first + second + third + forth;
            return addition;
        }
        public double Subtraction(double first, double second, double third, double forth)
        {
            double subtraction = first - second - third - forth;
            return subtraction;
        }
        public double Multiplication(double first, double second, double third, double forth)
        {
            double multiplication = first * second * third * forth;
            return multiplication;
        }

    }
}
