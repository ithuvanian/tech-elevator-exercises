using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDExercises
{
    public class NumbersToWords
    {
        public string OutputWords(int number)
        {
            if (number == 0)
            {
                return "zero";
            }

            string[] smallNum =
                {
                    "",
                    "one",
                    "two",
                    "three",
                    "four",
                    "five",
                    "six",
                    "seven",
                    "eight",
                    "nine",
                    "ten",
                    "eleven",
                    "twelve",
                    "thirteen",
                    "fourteen",
                    "fifteen",
                    "sixteen",
                    "seventeen",
                    "eighteen",
                    "nineteen"
                };

            string[] tyNum =
                {
                    "",
                    "ten",
                    "twenty",
                    "thirty",
                    "forty",
                    "fifty",
                    "sixty",
                    "seventy",
                    "eighty",
                    "ninety",
                };

            string words = "";

            if (number >= 100000)
            {
                int hThousands = number / 100000;
                words += $"{smallNum[hThousands]} hundred";
                number %= 100000;
                if (number < 1000)
                {
                    words += " thousand";
                }
                else
                {
                    words += " ";
                }
            }
            if (number >= 10000)
            {
                int tThousands = number / 10000;
                if (tThousands == 1)
                {
                    int teens = number / 1000;
                    words += $"{smallNum[teens]} thousand";
                    number -= teens * 10000;
                }
                else
                {
                    words += $"{tyNum[tThousands]}";
                    number %= 10000;
                    if (number > 0)
                    {
                        words += "-";
                    }
                }

            }
            if (number >= 1000)
            {
                int thousands = number / 1000;
                words += $"{smallNum[thousands]} thousand";
                number %= 1000;
                if (number >= 100)
                {
                    words += ", ";
                }
            }
            if (number >= 100)
            {
                int hundreds = number / 100;
                words += $"{smallNum[hundreds]} hundred";
                number %= 100;
                if (number > 0)
                {
                    words += " and ";
                }
            }
            if (number >= 10)
            {
                if (number < 20)
                {
                    words += $"{smallNum[number]}";
                    return words;
                }
                else
                {
                    int tens = number / 10;
                    words += $"{tyNum[tens]}";
                    number %= 10;
                    if (number > 0)
                    {
                        words += "-";
                    }
                }
            }
            if (number > 0)
            {
                words += $"{smallNum[number]}";
            }
            return words;
        }
    }
}
