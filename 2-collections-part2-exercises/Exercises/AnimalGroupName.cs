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
         * Given the name of an animal, return the name of a group of that animal
         * (e.g. "Elephant" -> "Herd", "Rhino" - "Crash").  
         * 
         * The animal name should be case insensitive so "elephant", "Elephant", and 
         * "ELEPHANT" should all return "herd". 
         * 
         * If the name of the animal is not found, null, or empty, return "unknown". 
         * 
         * Rhino -> Crash
         * Giraffe -> Tower
         * Elephant -> Herd
         * Lion -> Pride
         * Crow -> Murder
         * Pigeon -> Kit
         * Flamingo -> Pat
         * Deer -> Herd
         * Dog -> Pack
         * Crocodile -> Float
         *
         * animalGroupName("giraffe") → "Tower"
         * animalGroupName("") -> "unknown"         
         * animalGroupName("walrus") -> "unknown"
         * animalGroupName("Rhino") -> "Crash"
         * animalGroupName("rhino") -> "Crash"
         * animalGroupName("elephants") -> "unknown"
         * 
         */


        public string AnimalGroupName(string animalName)
        {
            Dictionary<string, string> Groups = new Dictionary<string, string>
            {
                { "rhino", "Crash" },
                { "giraffe", "Tower" },
                { "elephant", "Herd" },
                { "lion", "Pride" },
                { "crow", "Murder" },
                { "pigeon", "Kit" },
                { "flamingo", "Pat" },
                { "deer", "Herd" },
                { "dog", "Pack" },
                { "crocodile", "Float" }
            };

            string iName = animalName.ToLower();

            if (!Groups.ContainsKey(iName))
            {
                return "unknown";
            }
            else
            {
                return Groups[iName];
            }
        }
    }
}
            //switch (iName)
            //{
            //    case "rhino":
            //        return "Crash";
            //    case "giraffe":
            //        return "Tower";
            //    case "elephant":
            //        return "Herd";
            //    case "lion":
            //        return "Pride";
            //    case "crow":
            //        return "Murder";
            //    case "pigeon":
            //        return "Kit";
            //    case "flamingo":
            //        return "Pat";
            //    case "deer":
            //        return "Herd";
            //    case "dog":
            //        return "Pack";
            //    case "crocodile":
            //        return "Float";
            //    default:
            //        return "unknown";
            //}