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
         * Given an string representing an item number (a.k.a. SKU), return the discount percentage if the item is on sale.
         * If the item is not on sale, return 0.00.
         * 
         * If the item number is empty or null, return 0.00.
         * 
		 * Dictionary to start with
		 *
         * "KITCHEN4001" -> 0.20
         * "GARAGE1070" -> 0.15
         * "LIVINGROOM"	-> 0.10
         * "KITCHEN6073" -> 0.40
         * "BEDROOM3434" -> 0.60
         * "BATH0073" -> 0.15
         * 
         * The item number should be case insensitive so "kitchen4001", "Kitchen4001", and "KITCHEN4001"
         * should all return 0.20.
         *  
         * isItOnSale("kitchen4001") → 0.20
         * isItOnSale("") → 0.00
         * isItOnSale("GARAGE1070") → 0.15
         * isItOnSale("dungeon9999") → 0.00 
         * 
         */
        public double IsItOnSale(string userInput)
        {
            string itemNumber = userInput.ToUpper();

            Dictionary<string, double> Discounts = new Dictionary<string, double>();
            Discounts.Add("KITCHEN4001", .20);
            Discounts.Add("GARAGE1070", .15);
            Discounts.Add("LIVINGROOM", .10);
            Discounts.Add("KITCHEN6073", .40);
            Discounts.Add("BEDROOM3434", .60);
            Discounts.Add("BATH0073", .15);

            if (Discounts.ContainsKey(itemNumber))
            {
                return Discounts[itemNumber];
            }
            else return 0.00;
        }
    }
}
