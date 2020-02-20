using System;

namespace OOPS
{
    class Program : Abstraction_Interface, A
    {
        public override void Model()
        {
            Console.WriteLine(" this is abstract class");
        }

        public void show()
        {
            Console.WriteLine(" this is interface class");
        }


        public static void Main(string[] args)
        {

            Program obj = new Program();
            obj.Model();
            obj.show();

            Console.WriteLine("********************************************");

            Overloading obj2 = new Overloading();
            int sum1 = obj2.Sum(24, 28);
            Console.WriteLine("sum of " + "integer value : " + sum1);

            double sum2 = obj2.Sum(10.0, 20.0);
            Console.WriteLine("sum of " + "double value : " + sum2);

            Console.WriteLine("********************************************");

            Cricket c = new Cricket();
            c.play();

            Console.WriteLine("*********************************************");

            Virtual g = new Virtual();
            Virtual play1 = new Hokey();
            Virtual play2 = new Chess();  // Create a Dog object

            g.Games();
            play1.Games();
            play2.Games();

            Console.WriteLine("********************************************");
            Conflict Obj1 = new Conflict();
            Obj1.show();

            Console.WriteLine("********************************************");
            Method meth = new Method();
            int abc = meth.Sum1(24, 28);
            Console.WriteLine("sum of " + "integer value : " + abc);

            int ab = meth.Sum2(10,20,30);
            Console.WriteLine("sum of " + "integer value : " + ab);

            double cd = meth.Sum4(24.5, 28.6);
            Console.WriteLine("sum of " + "integer value : " + cd);

            meth.Info("SONAL",1);

            meth.Info(2, "SONAL");

            Console.WriteLine("********************************************");
            //Kathak k = new Kathak();
            //k.dance();
            Hiphop h = new Hiphop();
            h.dance();

            Console.WriteLine("********************************************");

            Parameter p = new Parameter();
            Console.WriteLine("parametrised constructor");

            Console.WriteLine("********************************************");
            Abc a = new Abc();
            a.Show();

            Console.WriteLine("********************************************");

            Object o = new Object();
            Object ob= new Object(10,20);
            Bac b = new Bac();
            Bac ba = new Bac(10,20);

            Console.WriteLine("********************************************");


            Operator_overloadin c1 = new Operator_overloadin(20, 40);
            c1.show(); 
            Operator_overloadin c2 = new Operator_overloadin();
            c2.show();  
            c2 = -c1;
            c2.show();   









        }
        
    }

    

}

