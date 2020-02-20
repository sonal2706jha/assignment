using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    class Method
    {
        //there are 3 methods i) changing no. of parameter ii) changing the data type iii) changing order of parameter
        public int Sum1 (int a, int b)
        {
            int value = a + b;
            return value;
        }
        public int Sum2 (int a , int b , int c) // changing no. of parameter
        {
            int value = a + b + c;
            return value;
        }

        public void Info(String name, int id)// changing the order of parameter
        {

            Console.WriteLine("Name : " + name + ", "
                              + "Id : " + id);
        }

        public void Info(int id, String name)// Now changing the order of parameter
        {

            Console.WriteLine("Name : " + name + ", "
                              + "Id : " + id);
        }

        public double Sum4(double x, double y)//Changing the data type
        {
            double value = x + y;
            return value;
        }


    }
}
