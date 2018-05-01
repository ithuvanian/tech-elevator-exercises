using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordCount
{


    public static class ReadingTxtFiles
    {
        public static void Main(string[] args)
        {

            
                string directory = @"C:\Users\kcumpson\team1-c-week4-pair-exercises\m1-w4d1-file-io-part1-exercises-pair\";
                string fileName = "alices_adventures_in_wonderland.txt";

                string fullPath = Path.Combine(directory, fileName);

            using (StreamReader sr = new StreamReader(fullPath))
            {
                List<string> words = new List<string>();
                List<string> sentences = new List<string>();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] wordsArray = line.Split(' ');
                    string[] sentencesArray = line.Split('.', '!', '?');
                    words.AddRange(wordsArray);
                    sentences.AddRange(sentencesArray);

                }
                int wordCount = words.Count;
                int sentenceCount = sentences.Count;

                
                Console.WriteLine("Alice In Wonderland: word count = " + wordCount + " sentence count = " + sentenceCount);
                Console.ReadLine();
                

                
                
            }
        }
    }
}






