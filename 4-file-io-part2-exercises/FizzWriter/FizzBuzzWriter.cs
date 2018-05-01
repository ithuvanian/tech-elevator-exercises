using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FizzWriter
{
    public class FizzBuzzWriter
    {
        public static void WriteToFile()
        {
            string dir = Environment.CurrentDirectory;
            string filename = "FizzBuzz.txt";
            string fullPath = Path.Combine(dir, filename);

            using (StreamWriter sw = new StreamWriter(fullPath, false))
            {
                for (int i = 1; i <= 300; i++)
                {

                    bool fizz = false;
                    bool buzz = false;
                    if (i % 3 == 0 || i % 10 == 3 || i / 10 == 3 || i / 100 == 3 || (i / 10) % 10 == 3)
                    {
                        fizz = true;
                    }
                    if (i % 5 == 0 || i % 10 == 5 || i / 10 == 5 || (i / 10) % 10 == 5)
                    {
                        buzz = true;
                    }
                    if (fizz && buzz)
                    {
                        sw.WriteLine("FizzBuzz");
                    }
                    else if (fizz)
                    {
                        sw.WriteLine("Fizz");
                    }
                    else if (buzz)
                    {
                        sw.WriteLine("Buzz");
                    }
                    else
                    {
                        sw.WriteLine(i);
                    }

                }
                sw.WriteLine("End of Sequence");
            }
        }
    }
}
