using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDExercises
{
    public class StringCalculator
    {


        public int GetSum(string numbers)
        {
            List<int> intDigits = new List<int>();
            List<string> stringDigits = new List<string>();

            if (numbers == "")
            {
                return 0;
            }

            stringDigits = numbers.Split(',','\n').ToList();

            foreach (string item in stringDigits)
            {
                int parsed = int.Parse(item);
                intDigits.Add(parsed);
            }

            int sum = 0;
            for (int i = 0; i < intDigits.Count; i++)
            {
                sum += intDigits[i];
            }
            return sum;
        }
    }
}
