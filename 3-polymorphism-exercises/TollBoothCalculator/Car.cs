using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothCalculator
{
    public class Car : IVehicle
    {

        public bool HasTrailer { get; }

        public Car(bool hasTrailer)
        {
            this.HasTrailer = hasTrailer;
        }

        public double CalculateToll(int distance)
        {
            double totalCharge = distance * .02;
            if (this.HasTrailer)
            {
                totalCharge += 1;
            }
            return totalCharge;
        }

        public override string ToString()
        {
            return "Car";
        }


    }
}
