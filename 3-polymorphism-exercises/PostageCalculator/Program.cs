using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter the Weight of the Package: ");
            double inputWeight = double.Parse(Console.ReadLine());
            Console.Write("(P)ounds or (O)unces? ");
            string unit = Console.ReadLine();
            if (unit.ToUpper().StartsWith("P"))
            {
                Console.WriteLine("Given number taken as pounds.");
                inputWeight *= 16;
            }
            else
            {
                Console.WriteLine("Given number taken as ounces.");
            }
            Console.Write("What distance will it be travelling to? ");
            int inputDist = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Postal Service, 1st Class: ");
            Console.WriteLine(new PostalService(1).CalculateRate(inputDist, inputWeight).ToString("$0.00"));
            Console.Write("Postal Service, 2nd Class: ");
            Console.WriteLine(new PostalService(2).CalculateRate(inputDist, inputWeight).ToString("$0.00"));
            Console.Write("Postal Service, 3rd Class: ");
            Console.WriteLine(new PostalService(3).CalculateRate(inputDist, inputWeight).ToString("$0.00"));
            Console.Write("FexEd: ");
            Console.WriteLine(new FexEd().CalculateRate(inputDist, inputWeight).ToString("$0.00"));
            Console.Write("SPU Next-Day: ");
            Console.WriteLine(new SPUNextDay().CalculateRate(inputDist, inputWeight).ToString("$0.00"));
            Console.Write("SPU Two-Day: ");
            Console.WriteLine(new SPUTwoDay().CalculateRate(inputDist, inputWeight).ToString("$0.00"));
            Console.Write("SPU Four-Day: ");
            Console.WriteLine(new SPUFourDay().CalculateRate(inputDist, inputWeight).ToString("$0.00"));

        }
    }
}
