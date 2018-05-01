using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    /* OPTIONAL */
    public class KataPrimeFactors
    {
        public List<int> Factorize(int n)
        {
            List<int> factors = new List<int>();

            int i = 2;
            while (n > 1)
            {
                if (n % i == 0)
                {
                    n /= i;
                    factors.Add(i);
                }
                else
                {
                    i++;
                }

            }
            return factors;


        }

    }
}
