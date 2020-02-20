using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    class Virtual // Base class (parent) 
    {
        // It is the method that can be declared again in child class.
        //It has implementation of both parent and child class.
        //This method is made by using of  virtual keyword accompained by override method.
        
            public virtual void Games()
            {
                Console.WriteLine("to play");
            }
        }

        class Hokey : Virtual  // Derived class (child) 
        {
            public override void Games() // with every virtual class we use override
            {
                Console.WriteLine("open door game");
            }
        }

        class Chess : Virtual  // Derived class (child) 
        {
            public override void Games()
            {
                Console.WriteLine("in door game");
            }
        }
    }


