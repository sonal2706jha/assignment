using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    // In this child class have same method name and same signature as parent.
     
    class Overriding
    { 
            public virtual void play()              // base class method
            {
                Console.WriteLine("Playing is the best exercise ");
            }
        }
        class Cricket : Overriding      //  derived class
        {
            public override void play()        // derived class method
            {
                base.play();
                Console.WriteLine("Play Cricket");
            }
        }
    }

