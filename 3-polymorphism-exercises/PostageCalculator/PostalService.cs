using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator
{

    public class PostalService : IDeliveryDriver
    {
        public int ServiceClass { get; }

        public PostalService(int serviceClass)
        {
            this.ServiceClass = serviceClass;
        }

        //first class

        public double CalculateRate(int distance, double weight)
        {
            double rate = distance;

            switch (this.ServiceClass)
            {
                //first class
                case 1:
                    if (weight <= 2)
                    {
                        rate *= .035;
                    }
                    else if (weight <= 8)
                    {
                        rate *= .040;
                    }
                    else if (weight <= 15)
                    {
                        rate *= .047;
                    }
                    else if (weight <= 16 * 3)
                    {
                        rate *= .195;
                    }
                    else if (weight <= 16 * 8)
                    {
                        rate *= .45;
                    }
                    else
                    {
                        rate *= .5;
                    }
                    break;

                //second class
                case 2:
                    if (weight <= 2)
                    {
                        rate *= .0035;
                    }
                    else if (weight <= 8)
                    {
                        rate *= .0040;
                    }
                    else if (weight <= 15)
                    {
                        rate *= .0047;
                    }
                    else if (weight <= 16 * 3)
                    {
                        rate *= .0195;
                    }
                    else if (weight <= 16 * 8)
                    {
                        rate *= .045;
                    }
                    else
                    {
                        rate *= .05;
                    }
                    break;

                //third class
                default:
                    if (weight <= 2)
                    {
                        rate *= .002;
                    }
                    else if (weight <= 8)
                    {
                        rate *= .0022;
                    }
                    else if (weight <= 15)
                    {
                        rate *= .0024;
                    }
                    else if (weight <= 16 * 3)
                    {
                        rate *= .015;
                    }
                    else if (weight <= 16 * 8)
                    {
                        rate *= .016;
                    }
                    else
                    {
                        rate *= .017;
                    }
                    break;
            }
            return rate;
        }
    }
}

