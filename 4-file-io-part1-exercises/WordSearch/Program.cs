using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Ask the user for the search string
            //2. Ask the user for the file path
            //3. Open the file
            //4. Loop through each line in the file
            //5. If the line contains the search string, print it out along with its line number
            Console.WriteLine("Please enter text to search for:");
            string searchStr = Console.ReadLine();
            Console.WriteLine("Please enter the name of the text file to search: ");
            string filename = Console.ReadLine();
            while (filename != "alices_adventures_in_wonderland.txt" && filename != "Hamlet.txt")
            {
                Console.WriteLine("uhhhh, you can only use alices_adventures_in_wonderland.txt or Hamlet.txt\nTry again: ");
                filename = Console.ReadLine();
            }
            Console.WriteLine("Do you want to make this search case-insenstive? Y/N: ");
            string caseInput = Console.ReadLine();
            Console.WriteLine();

            string directory = Environment.CurrentDirectory;
            string fullPath = Path.Combine(directory, filename);
            Console.WriteLine(filename);

            using (StreamReader sr = new StreamReader(fullPath))
            {
                int lineNum = 1;
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string lowercaseLine = line.ToLower();
                    if (caseInput.StartsWith("Y") || caseInput.StartsWith("y"))
                    {
                        if (lowercaseLine.Contains(searchStr.ToLower()))
                        {
                            Console.Write($"{lineNum}) ");
                            Console.WriteLine(line);
                        }
                    }
                    else
                    {
                        if (line.Contains(searchStr))
                        {
                            Console.Write($"{lineNum}) ");
                            Console.WriteLine(line);
                        }
                    }
                    lineNum++;
                }
            }
            Console.ReadLine();
        }
    }
}
