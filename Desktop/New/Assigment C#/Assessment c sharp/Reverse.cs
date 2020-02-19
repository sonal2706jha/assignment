using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_c_sharp
{
    class Reverse
    {
        //Reverse of string without using inbuilt function
        public void rev()
        {
            String name = "SONAL";//Sting name is assigned 
            char[] charArray = name.ToCharArray();//used to assign string name in charArray
            Array.Reverse(charArray);//this is use to reverse the array.
            Console.WriteLine(new string(charArray));
        }
    }
}
