using System;

namespace Q10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter two numbers: ");

            try
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                int result = num1 / num2;

                Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
            }
            catch (DivideByZeroException ex)
            {
                
                Console.Write("Cannot divide by zero. Please try again.");
            }
            catch (InvalidOperationException ex)
            {
            
                Console.Write("Not a valid number. Please try again.");
            }
            catch (FormatException ex)
            {
               
                Console.Write("Not a valid number. Please try again.");
            }

            Console.ReadKey();
        }

    }
}

