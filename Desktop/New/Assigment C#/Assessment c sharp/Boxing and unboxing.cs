using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_c_sharp
{ //Boxing--> It is the process of convertion of value type to the reference type.
    // Unboxing --> It is the process of convertion of reference type to the value type.
    class Boxing_and_unboxing
    { 
        public void box()
    
        {
            int n = 5;
            object obj = n;//Boxing
            int i = (int)obj;//Unboxing
            Console.WriteLine("value" + n);
            Console.WriteLine("object" + obj);
        }
    }
}
