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
         Given two lists of Integers, interleave them beginning with the first element in the first list followed
         by the first element of the second. Continue interleaving the elements until all elements have been interwoven.
         Return the new list. If the lists are of unequal lengths, simply attach the remaining elements of the longer
         list to the new list before returning it.
		 DIFFICULTY: HARD
         interleaveLists( [1, 2, 3], [4, 5, 6] )  ->  [1, 4, 2, 5, 3, 6]
         */
        public List<int> InterleaveLists(List<int> listOne, List<int> listTwo)
        {
            Queue<int> q1 = new Queue<int>(listOne);
            Queue<int> q2 = new Queue<int>(listTwo);
            List<int> finalList = new List<int>();
            if (q1.Count >= q2.Count)
            {
                foreach (var item in q2)
                {
                    finalList.Add(q1.Dequeue());
                    finalList.Add(item);
                }
                foreach (var item in q1)
                {
                    finalList.Add(item);
                }
            }
            else
            {
                foreach (var item in q1)
                {
                    finalList.Add(item);
                    finalList.Add(q2.Dequeue());
                }
                foreach (var item in q2)
                {
                    finalList.Add(item);
                }
            }
            return finalList;
        }
    }
}
