using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearConvert
{
    class Program
    {
        /*
         The foot to meter conversion formula is:
 	        m = f * 0.3048
 	
         The meter to foot conversion formula is:
 	        f = m * 3.2808399
 	
         Write a command line program which prompts a user to enter a length, and whether the measurement is in (m)eters or (f)eet.
         Convert the length to the opposite measurement, and display the old and new measurements to the console.
  
         C:\Users> LinearConvert
         Please enter the length: 58
         Is the measurement in (m)eter, or (f)eet? f
         58f is 17m.
         */

        static void Main(string[] args)
        {
            for (int i = 0; i == i; i++)
            {
                Console.Write("Please enter the length: ");
                int length = int.Parse(Console.ReadLine());
                Console.Write("Is the measurement in (m)eter, or (f)eet? ");
                string unit = Console.ReadLine();
                if (unit == "f")
                {
                    int meters = (int)(length * .3048);
                    Console.WriteLine($"{length}f is {meters}m.");
                }
                else if (unit == "m")
                {
                    int feet = (int)(length * 3.2808399);
                    Console.WriteLine($"{length}m is {feet}f.");
                }
            }
        }
    }
}
