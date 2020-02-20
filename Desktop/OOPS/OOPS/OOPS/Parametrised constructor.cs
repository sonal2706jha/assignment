using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    // It is a constructor with at least one parameter.
    // We can initialize each instance of class to the different values.
    class Parametrised_constructor
    {
        String name;
        int pin;


       public Parametrised_constructor(String name, int pin)
        {
            this.name = name;
            this.pin = pin;
        }
    }
     class Parameter : Parametrised_constructor
    {
        public Parameter(): base("sonal",1001)
        {

        }
    }
}
