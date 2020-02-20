using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    public abstract class Abstract_and_encapsulation
    {
        // Abstract : It is showing of essential method to the user .
        // It is the which we show to the user.
        // It focus on the output without thinking of process.

        public abstract void Show();
        
    }

    public class Abc : Abstract_and_encapsulation
    {
        // Encapsulation : It is the hidding of data .
        // It is the which we hide the to the user.
        // It hides how actually an object works.
        // It is used to protect the information in an object from another object.

        int calling = 10;
        public override void Show ()
        {
            int song, vedios;
            song = 3;
            vedios = 4;
            Console.WriteLine("No. of songs and vedios");
        }
        void list()
        {
            Console.WriteLine("no. of calls");
        }

    }

}


       






  