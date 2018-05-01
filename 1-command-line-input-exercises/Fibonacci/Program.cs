using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        /*
         The Fibonacci numbers are the integers in the following sequence:  
	        0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, ...
         By definition, the first two numbers in the Fibonacci sequence are 0 and 1, and each subsequent number is the sum of the previous two.
 
         Write a command line program which prompts the user for an integer value and display the Fibonacci sequence leading up to that number.
  
         C:\Users> Fiboncci
         Please enter the Fibonacci number: 25
         
         0, 1, 1, 2, 3, 5, 8, 13, 21
         */
        static void Main(string[] args)
        {
            for (int i = 0; i == i; i++)
            {
                int f1 = 0;
                int f2 = 1;
                int f3 = 0;
                Console.WriteLine("Please enter an integer:");
                int limit = int.Parse(Console.ReadLine());
                if (limit == 0)
                {
                    Console.WriteLine('0');
                }
                else
                {
                    Console.Write("0, 1, ");
                    while ((f1 + f3) <= limit)
                    {
                        f3 = f1 + f2;
                        f1 = f2;
                        f2 = f3;
                        if ((f1 + f2) > limit)
                        {
                            Console.Write(f3);
                        }
                        else
                        {
                            Console.Write($"{f3}, ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}