using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the name of the input file?");
            string inputFile = Console.ReadLine().ToLower();
            if (!inputFile.Contains('.'))
            {
                inputFile += ".txt";
            }
            Console.WriteLine("How many lines of text (max) should there be in the split files?");
            int linesPerFile = int.Parse(Console.ReadLine());

            string dir = Environment.CurrentDirectory;
            string inputFullPath = Path.Combine(dir, inputFile);
            using (StreamReader sr = new StreamReader(inputFullPath))
            {
                int lineCount = File.ReadLines(inputFullPath).Count();
                int filesNeeded = lineCount / linesPerFile;
                if (lineCount % linesPerFile > 0)
                {
                    filesNeeded++;
                }

                while (!sr.EndOfStream)
                {
                    for (int i = 1; i <= filesNeeded; i++)
                    {
                        string outputFile = "input" + i.ToString() + ".txt";
                        string outputFullPath = Path.Combine(dir, outputFile);
                        Console.WriteLine("Generating " + outputFile);
                        using (StreamWriter sw = new StreamWriter(outputFullPath, false))
                        {
                            for (int j = 0; j < linesPerFile; j++)
                            {
                                string line = sr.ReadLine();
                                sw.WriteLine(line);
                            }
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}

