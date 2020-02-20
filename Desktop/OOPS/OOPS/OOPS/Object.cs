using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    // different implementation of  objects.....
    class Object
    {
        public Object()
        {
            Console.WriteLine("this is A");
        }
        public Object(int a, int b)
        {
            Console.WriteLine("this in parameter");
        }
        static Object()
        {
            Console.WriteLine("this is static");
        }
    }

        class Bac : Object
        {
            public Bac()
            {
                Console.WriteLine("this is B");
            }

            public Bac(int a, int b)
            {
                Console.WriteLine("this is parameter");
            }

            static Bac()
            {
                Console.WriteLine("this is static");
            }
        } 
    }

