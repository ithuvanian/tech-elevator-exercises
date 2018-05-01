using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IVehicle> AllVehicles = new List<IVehicle>();
            AllVehicles.Add(new Car(false));
            AllVehicles.Add(new Car(true));
            AllVehicles.Add(new Truck(4));
            AllVehicles.Add(new Truck(8));
            AllVehicles.Add(new Tank());


            Random r = new Random();
            List<int> totalMiles = new List<int>();
            List<double> totalRevenue = new List<double>();

            foreach (IVehicle Vehicle in AllVehicles)
            {
                int miles = r.Next(10, 240);
                totalMiles.Add(miles);
                double toll = Vehicle.CalculateToll(miles);
                totalRevenue.Add(toll);
                Console.WriteLine(Vehicle.ToString());
                Console.WriteLine(miles + " miles");
                Console.WriteLine(toll.ToString("$0.00"));
                Console.WriteLine();
            }

            int sumOfMiles = 0;
            foreach(int miles in totalMiles)
            {
                sumOfMiles += miles;
            }

            double sumOfRevenue = 0;
            foreach (double revenue in totalRevenue)
            {
                sumOfRevenue += revenue;
            }
            Console.WriteLine("Total vehicle miles: " + sumOfMiles);
            Console.WriteLine("Total tollbooth revenue: " + sumOfRevenue.ToString("$0.00"));
            Console.ReadLine();
        }
    }
}
