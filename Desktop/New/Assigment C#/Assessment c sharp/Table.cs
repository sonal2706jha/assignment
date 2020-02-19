using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_c_sharp
{

    class Table
    {
        public void tab()
        {
            Console.WriteLine("Table upto 5");
            int i, j;
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= 10; j++)
                {
                    Console.WriteLine(+i + "*" + j + "=" + i * j);
                    Console.WriteLine("\n");
                }

                Console.WriteLine("***********************************************");
            }
        }
    }
}
