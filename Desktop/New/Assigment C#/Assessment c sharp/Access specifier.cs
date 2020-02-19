using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_c_sharp
{
    // Access specifier--> It is of 4 type a)Private b)Public c)Internal d)Protected
    class Access_specifier
    {

        internal int mob = 54321;
        private int X = 12;
        protected string name = "sonal";
        protected internal string title = "jha";
        public string company = "TTN";
        public void pub()
        {
            Console.WriteLine("this is public");
        }


    }
    class Acc : Access_specifier
    {
        Access_specifier obj = new Access_specifier();
        public void pu()
        {
            Console.WriteLine("this is pub" + company);
            Console.WriteLine("this is internal" + mob);
            Console.WriteLine("this is protected" + name);
            Console.WriteLine("this is protected internal" + title);


        }

    }
}

   