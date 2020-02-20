using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    public abstract class Abstraction_Interface
    {

        // In abstract class it contains both declaration and defination of class
        // Constructor can be made.
        //No multiple inheritance.
        
        //Non-Abstract Method   
        public void Write()
        {
            Console.WriteLine("This is used to write anything");
        }

        //Abstract Method   
        public abstract void Model();


    }

    internal interface A
        // In interface class it contains  declaration only.
        // Constructor can't be made.
        // Multiple inheritance can be done.
    {
        void show();
    }
}

    



