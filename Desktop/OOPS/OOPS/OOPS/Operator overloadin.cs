using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    public class Operator_overloadin
    {

        private int x;
        private int y;
        public Operator_overloadin()
        {
        }
        public Operator_overloadin(int i, int j)
        {
            x = i;
            y = j;
        }
        public void ShowXY()
        {
            Console.WriteLine("{0} {1}", x, y);
        }
        public static Operator_overloadin operator -(Operator_overloadin c)
        {
            Operator_overloadin temp = new Operator_overloadin();
            temp.x = -c.x;
            temp.y = -c.y;
            return temp;
        }
    }
}

    
