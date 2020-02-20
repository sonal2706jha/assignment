using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
     class Overloading // It has same method name but different signature.
    {
        public int Sum(int a, int b)//same method but different paremeter.
        {
            int value = a+b;
            return value;
        }
        public double Sum(double a,double b)// same method but different parameter.
        {
            double value = a+b;
            return value;
        }

    }
}
