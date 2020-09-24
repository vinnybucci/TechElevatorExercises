using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
         * AnimalGroupName("giraffe") → "Tower"
         * AnimalGroupName("") -> "unknown"
         * AnimalGroupName("walrus") -> "unknown"
         * AnimalGroupName("Rhino") -> "Crash"
         * AnimalGroupName("rhino") -> "Crash"
         * AnimalGroupName("elephants") -> "unknown"
         *
         */
        public string AnimalGroupName(string animalName)
        {
            Dictionary<string, string> animal = new Dictionary<string, string>();

            animal["rhino"] = "Crash";
            animal["giraffe"] = "Tower";
            animal["elephant"] = "Herd";
            animal["lion"] = "Pride";
            animal["crow"] = "Murder";
            animal["pigeon"] = "Kit";
            animal["flamingo"] = "Pat";
            animal["deer"] = "Herd";
            animal["dog"] = "Pack";
            animal["crocodile"] = "Float";
            string animalValue = "unknown";
            if (animalName == null)
            {
                animalValue = "unknown";
            }

            else if (animal.ContainsKey(animalName.ToLower()))
            {
                animalValue = animal[animalName.ToLower()];
            }
            else
            {
                animalValue = "unknown";
            }



            return animalValue;
        }

    }
}
