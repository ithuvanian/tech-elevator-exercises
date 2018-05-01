using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothCalculator
{
    public class Tank : IVehicle
    {
        public double CalculateToll(int distance)
        {
            return 0;
        }

        public override string ToString()
        {
            return "Tank";
        }
    }
}
