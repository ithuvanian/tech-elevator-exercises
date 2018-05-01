using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given an array of Integers, return a List that contains the same Integers (as Strings). Except any multiple of 3
         should be replaced by the String "Fizz", any multiple of 5 should be replaced by the String "Buzz",
         and any multiple of both 3 and 5 should be replaced by the String "FizzBuzz"
         ** INTERVIEW QUESTION **

         fizzBuzzList( {1, 2, 3} )  ->  ["1", "2", "Fizz"]
         fizzBuzzList( {4, 5, 6} )  ->  ["4", "Buzz", "Fizz"]
         fizzBuzzList( {7, 8, 9, 10, 11, 12, 13, 14, 15} )  ->  ["7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"]
         
         HINT: To convert an integer x to a string you can call x.ToString() in your code (e.g. if x = 1 then x.ToString() equals "1")
         */
        public List<string> FizzBuzzList(int[] integerArray)
        {
            List<string> finalList = new List<string>();
            foreach (int item in integerArray)
            {
                if (item % 15 == 0)
                {
                    finalList.Add("FizzBuzz");
                }
                else if (item % 5 == 0)
                {
                    finalList.Add("Buzz");
                }
                else if (item % 3 == 0)
                {
                    finalList.Add("Fizz");
                }
                else
                {
                    finalList.Add(item.ToString());
                }
            }
            return finalList;
        }

    }
}
