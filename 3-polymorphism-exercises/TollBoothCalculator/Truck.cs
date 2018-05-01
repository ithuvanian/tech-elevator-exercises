using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothCalculator
{
    public class Truck : IVehicle
    {

        public int NumberOfAxles { get; }

        public Truck(int numberOfAxles)
        {
            this.NumberOfAxles = numberOfAxles;
        }

        public double CalculateToll(int distance)
        {
            double totalCharge;
            switch (this.NumberOfAxles)
            {
                case 4:
                    totalCharge = distance * .04;
                    break;
                case 6:
                    totalCharge = distance * .045;
                    break;
                default:
                    totalCharge = distance * .048;
                    break;
            }
            return totalCharge;
        }

        public override string ToString()
        {
            return "Truck";
        }
    }
}
