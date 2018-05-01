using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator
{
    public class SPUFourDay : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)
        {
            double pounds = weight / 16;
            return (pounds * 0.0050) * distance;
        }
    }

    public class SPUTwoDay : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)
        {
            double pounds = weight / 16;
            return (pounds * 0.050) * distance;
        }
    }

    public class SPUNextDay : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)
        {
            double pounds = weight / 16;
            return (pounds * 0.075) * distance;
        }
    }
}
