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
         Given an array of Strings, return a List containing the same Strings in the same order 
         except for any words that contain exactly 4 characters.
         no4LetterWords( {"Train", "Boat", "Car"} )  ->  ["Train", "Car"]
         no4LetterWords( {"Red", "White", "Blue"} )  ->  ["Red", "White"]
         no4LetterWords( {"Jack", "Jill", "Jane", "John", "Jim"} )  ->  ["Jim"]
         */
        public List<string> No4LetterWords(string[] stringArray)
        {
            List<string> finalList = new List<string>();
            foreach (var item in stringArray)
            {
                if (item.Length != 4)
                {
                    finalList.Add(item);
                }
            }
            return finalList;
        }

    }
}
