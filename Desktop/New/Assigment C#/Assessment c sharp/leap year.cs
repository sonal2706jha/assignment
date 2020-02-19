using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_c_sharp
{
    class leap_year
    {
        public void leap()
        {
            int year;
            Console.WriteLine("whether it is leap year or not?");
            year = Convert.ToInt32(Console.ReadLine());
            if ((year % 400) == 0)
                Console.WriteLine("is leap year");
            else if ((year % 100) == 0)
                Console.WriteLine("is not leap year");
            else if ((year % 4) == 0)
                Console.WriteLine("is leap year");
            else
                Console.WriteLine("NOT");
        }
    }
}
