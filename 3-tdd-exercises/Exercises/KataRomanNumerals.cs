using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{

    public class KataRomanNumerals
    {

        string[] romHundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        string[] romTens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        string[] romOnes = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };


        public string ConvertToRomanNumeral(int n)
        {
            string rom = "";
            while (n > 1000)
            {
                n -= 1000;
                rom += "M";
            }
            if (n > 100)
            {
                int h = n / 100;
                rom += romHundreds[h];
                n -= 100 * h;
            }
            if (n > 10)
            {
                int t = n / 10;
                rom += romTens[t];
                n -= 10 * t;
            }
            if (n > 0)
            {
                rom += romOnes[n];
            }
            return rom;
        }


        public int ConvertToDigit(string romanNumeral)
        {
            int total = 0;
            while (romanNumeral.StartsWith("M"))
            {
                total += 1000;
                romanNumeral = romanNumeral.Substring(1);
            }
            string finalHundred = "";
            int finalIndex = 0;
            for (var i = 0; i < romHundreds.Length; i++)
            {
                int index = romanNumeral.IndexOf(romHundreds[i]);
                if (index == 0)
                {
                    finalIndex = i;
                    finalHundred = romHundreds[i];
                }
            }
            romanNumeral = romanNumeral.Substring(finalHundred.Length);
            total += finalIndex * 100;

            string finalTen = "";
            finalIndex = 0;
            for (var i = 0; i < romTens.Length; i++)
            {
                int index = romanNumeral.IndexOf(romTens[i]);
                if (index == 0)
                {
                    finalIndex = i;
                    finalTen = romTens[i];
                }
            }
            romanNumeral = romanNumeral.Substring(finalTen.Length);
            total += finalIndex * 10;

            string finalOne = "";
            finalIndex = 0;
            for (var i = 0; i < romOnes.Length; i++)
            {
                int index = romanNumeral.IndexOf(romOnes[i]);
                if (index == 0)
                {
                    finalIndex = i;
                    finalOne = romOnes[i];
                }
            }
            total += finalIndex;
            return total;
        }
    }

}

