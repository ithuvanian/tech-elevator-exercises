using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FindAndReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type the file you would like to alter. ex:alices_adventures_in_wonderland.txt");
            string fileName = Console.ReadLine();

            Console.WriteLine("What piece of text would you like to replace?");
            string oldText = Console.ReadLine();

            Console.WriteLine("What text would you like to replace " + oldText + " with?");
            string newText = Console.ReadLine();

            Console.WriteLine("And last but not least, what would you like the new file to be named?");
            string newFileName = Console.ReadLine();

            string directory = Environment.CurrentDirectory;
            string fullPath = Path.Combine(directory, fileName);
            string outputPath = Path.Combine(directory, newFileName);

            using (StreamReader sr = new StreamReader(fullPath))
            {
                string wholeFile = sr.ReadToEnd();
                wholeFile = wholeFile.Replace(oldText, newText);


                //Console.Write(wholeFile);
                //Console.ReadLine();
                using (StreamWriter sw = new StreamWriter(outputPath,false))
                {
                    sw.WriteLine(wholeFile);
                }
            }


        }
    }
}
