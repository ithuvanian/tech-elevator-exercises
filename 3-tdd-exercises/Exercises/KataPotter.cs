using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataPotter
    {
        decimal[] priceLevels = { 0M, 8.0M, 15.2M, 21.6M, 25.6M, 30.0M };


        public decimal GetCost(int[] books)
        {
            int[] eachBookQty = new int[5];

            for (int i = 0; i < books.Length; i++)
            {
                int bookNum = books[i];
                eachBookQty[bookNum - 1]++;
            }

            List<int> sets = new List<int>();
            int booksInSet = 0;

            while (eachBookQty.Sum() > 0)
            {
                booksInSet = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (eachBookQty[i] > 0)
                    {
                        eachBookQty[i]--;
                        booksInSet++;
                    }
                }
                sets.Add(booksInSet);

            }

            decimal sum = 0.0M;
            foreach (int setQty in sets)
            {
                sum += priceLevels[setQty];
            }
            return sum;
        }
    }
}




//decimal price = (books.Length) * 8;
//Array.Sort(books);
//int titles = 1;
//for (int i = 1; i < books.Length; i++)
//{
//    if (books[i] != books[i - 1])
//    {
//        titles++;
//    }
//}
//switch (titles)
//{
//    case 5:
//        return price *= .75M;
//    case 4:
//        return price *= .8M;
//    case 3:
//        return price *= .9M;
//    case 2:
//        return price *= .95M;
//    default:
//        return price;
//}


