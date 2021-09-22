using System.Collections.Generic;


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
            string animalGroup = "unknown";

            Dictionary<string, string> groupOfAnimals = new Dictionary<string, string>()
            {
                {"Rhino", "Crash"},
                {"Giraffe", "Tower"},
                {"Elephant", "Herd"},
                {"Lion", "Pride"},
                {"Crow", "Murder"},
                {"Pigeon", "Kit"},
                {"Flamingo", "Pat"},
                {"Deer", "Herd"},
                {"Dog", "Pack"},
                {"Crocodile", "Float"}                
            };

            if (animalName == null || animalName == "")
            {
                return animalGroup;
            }
            else if (groupOfAnimals.ContainsKey(AnimalNameToTitleCase(animalName)))
            {
                animalGroup = groupOfAnimals[AnimalNameToTitleCase(animalName)];
            }
            return animalGroup;
        }

        public string AnimalNameToTitleCase(string animalNameInput)
        {
            string firstLetterCapital = animalNameInput.Substring(0, 1).ToUpper();
            string restOfLettersLower = animalNameInput.Substring(1).ToLower();
            string animalNameinTitleCase = firstLetterCapital + restOfLettersLower;
            return animalNameinTitleCase;
        }
    }

}

