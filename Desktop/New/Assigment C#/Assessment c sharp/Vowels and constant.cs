using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_c_sharp
{
    class Vowels_and_constant
    {
        public void vow()
        {
            char ch;
            Console.WriteLine("Check vowels and constants");
            Console.Write("Input an Alphabet (A-Z or a-z) : ");
            ch = Convert.ToChar(Console.ReadLine().ToLower());
            int i = ch;
            if (i >= 48 && i <= 57)
            {
                Console.WriteLine("entered number");
            }
            else
            {
                switch (ch)
                {
                    case 'a':
                        Console.WriteLine("is vowel");
                        break;

                    case 'e':
                        Console.WriteLine("is vowel");
                        break;

                    case 'i':
                        Console.WriteLine("is vowel");
                        break;

                    case 'o':
                        Console.WriteLine("is vowel");
                        break;

                    case 'u':
                        Console.WriteLine("is vowel");
                        break;
                    default:
                        Console.WriteLine("Not a vowel");
                        break;





                }
            }
        }
    }
}
        

 
