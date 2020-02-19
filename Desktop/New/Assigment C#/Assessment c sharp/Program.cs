using System;

namespace Assessment_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Static_instance obj = new Static_instance();
            Console.WriteLine("instance variable value:" + obj.b);
            Console.WriteLine("static variable:" + Static_instance.a);

            leap_year obj1 = new leap_year();
            Console.WriteLine("leap year");
            obj1.leap();


            Table obj2 = new Table();
            Console.WriteLine("table");
            obj2.tab();

            Vowels_and_constant obj3 = new Vowels_and_constant();
            Console.WriteLine("vowels");
            obj3.vow();

            Boxing_and_unboxing obj4 = new Boxing_and_unboxing();
            Console.WriteLine("boxing and unboxing");
            obj4.box();

            Reverse obj5 = new Reverse();
            Console.WriteLine("boxing and unboxing");
            obj5.rev();

            Acc obj6 = new Acc ();
            obj6.pu();
           

            
            







        }


    }
}
