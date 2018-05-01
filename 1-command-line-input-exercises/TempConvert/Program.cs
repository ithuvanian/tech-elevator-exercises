using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConvert
{
    class Program
    {
        /*
         The Fahrenheit to Celsius conversion formula is:
 	        Tc = (Tf - 32) / 1.8
 	        where 'Tc' is the temperature in Celsius, and 'Tf' is the temperature in Fahrenheit
 	
         The Celsius to Fahrenheit conversion formula is:
 	        Tf = Tc * 1.8 + 32
 	         
        Write a command line program which prompts a user to enter a temperature, and whether its in degrees (C)elsius or (F)arenheit.
        Convert the temperature to the opposite degrees, and display the old and new temperatures to the console.

         C:\Users> TempConvert
         Please enter the temperature: 58
         Is the temperature in (C)elcius, or (F)arenheit? F
         58F is 14C.
        
         */
        static void Main(string[] args)
        {
            for (int i = 0; i == i; i++)
            {
                Console.Write("Please enter the temperature: ");
                int temp = int.Parse(Console.ReadLine());
                Console.Write("Is the temperature in (C)elsius, or (F)arenheit? ");
                string unit = Console.ReadLine();
                double convertedTemp;

                if (unit == "F")
                {
                    convertedTemp = (temp - 32) / 1.8;
                    double convertedDegrees = Math.Round(convertedTemp);
                    Console.WriteLine($"{temp}F is {convertedDegrees}C.");

                }
                else if (unit == "C")
                {
                    convertedTemp = (temp * 1.8) + 32;
                    double convertedDegrees = Math.Round(convertedTemp);
                    Console.WriteLine($"{temp}C is {convertedDegrees}F.");

                }
            }
        }
    }
}
