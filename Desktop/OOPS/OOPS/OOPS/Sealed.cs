using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    // Sealed class is used to restrict the process when it is written before override.
    // When in derived class sealed is written then after that class no other class will be implemented.
    class Sealed
    {
        public virtual void dance()              // base class method
        {
            Console.WriteLine("Dance helps to make you happy ");
        }
    }
    class Kathak : Sealed      //  derived class
    {
        public sealed override void dance()        // derived class method
        {
            base.dance();
            Console.WriteLine("Enjoy Dance");
        }
    }

    class Hiphop : Sealed      //  derived class
    {
        public override void dance()        // derived class method
        {
            base.dance();
            Console.WriteLine("Enjoy Dance");
        }
    }


}

