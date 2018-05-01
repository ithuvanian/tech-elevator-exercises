using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercises.Web.Models
{
    public class LastTwoModel
    {
        public string WordA { get; set; }
        public string WordB { get; set; }
        public string WordC { get; set; }
        public string WordD { get; set; }
        public string WordE { get; set; }
        public string WordF { get; set; }
        public string WordG { get; set; }
        public string WordH { get; set; }
        public string WordI { get; set; }
        public string WordJ { get; set; }

        public string RevLastTwo (string word)
        {
            if (word.Length > 1)
            {
                return word.Substring(0, word.Length - 2) + word[word.Length - 1] + word[word.Length - 2];
            }
            else return word;
        }

    }
}