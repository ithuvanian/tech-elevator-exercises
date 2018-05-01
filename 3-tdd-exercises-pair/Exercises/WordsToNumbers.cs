using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDExercises
{
    public class WordsToNumbers
    {
        public int OutputInts(string number)
        {
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

            number = number.Replace("thousand,", ". .*");
            number = number.Replace("thousand", ". .*");
            number = number.Replace("hundred", "..*");
            number = number.Replace("and", "");

            int sum = 0;

            List<string> numParts = number.Split('*').ToList<string>();

            for (int i = 0; i < numParts.Count; i++)
            {
                string thisWordPart = numParts[i];

                if (thisWordPart.Contains(".."))
                {
                    //hundreds or hundred thousands
                    int hMultiple = 0;
                    for (int j = 0; j < smallNum.Length; j++)
                    {
                        if (thisWordPart.Contains(smallNum[j]))
                        {
                            hMultiple = j;
                        }
                    }
                    sum += hMultiple * 100;

                    //check if thousand appears later on
                    for (int k = i; k < numParts.Count; k++)
                    {
                        if (numParts[k].Contains(". ."))
                        {
                            sum *= 1000;
                        }
                    }
                }

                else if (thisWordPart.Contains(". ."))
                {
                    //ten thousands
                    int tMultiple = 0;
                    for (int a = 0; a < tyNum.Length; a++)
                    {
                        if (thisWordPart.Contains(tyNum[a]))
                        {
                            tMultiple = a;
                        }
                    }
                    sum += tMultiple * 10000;

                    // this prevents the next loop from confusing six w sixty, etc
                    if (tMultiple >= 6)
                    {
                        thisWordPart = thisWordPart.Substring(3);
                    }

                    //thousands
                    tMultiple = 0;
                    for (int b = 0; b < smallNum.Length; b++)
                    {
                        if (thisWordPart.Contains(smallNum[b]))
                        {
                            tMultiple = b;
                        }
                    }
                    sum += tMultiple * 1000;
                }

                else
                {
                    //tens
                    int oMultiple = 0;
                    for (int c = 0; c < tyNum.Length; c++)
                    {
                        if (thisWordPart.Contains(tyNum[c]))
                        {
                            oMultiple = c;
                        }
                    }
                    sum += oMultiple * 10;

                    if (oMultiple >= 6)
                    {
                        thisWordPart = thisWordPart.Substring(3);
                    }

                    //ones
                    oMultiple = 0;
                    for (int d = 0; d < smallNum.Length; d++)
                    {
                        if (thisWordPart.Contains(smallNum[d]))
                        {
                            oMultiple = d;
                        }
                    }
                    sum += oMultiple;
                }
            }
            return sum;
        }
    }
}
