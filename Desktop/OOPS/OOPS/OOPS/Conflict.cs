using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    //It makes the confusion that which method of interface will be implemented. 
    interface C
    {
        void show(); // method1
    }

    interface B
    {
        void show(); // same method
    }

    class Conflict : C, B // it will show conflict or we can say cofusion while executing which method will be implemented 
    {
        public void show()
        {
            Console.WriteLine("Hello to all");
        }
    }
}
