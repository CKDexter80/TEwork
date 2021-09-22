using System;
using System.Collections.Generic;

namespace CollectionsPart2Lecture
{
    public class CollectionsPart2Lecture
    {
        static void Main(string[] args)
        {
            Console.WriteLine("####################");
            Console.WriteLine("       DICTIONARIES");
            Console.WriteLine("####################");
            Console.WriteLine();
            //what kind of dictionary
            //vending machine items
            //key //value
            Dictionary<int, string> contentsOfVM = new Dictionary<int, string>()
            {	//keypad# //item at location
				{512, "cheetos" },
                {1024, "flaming hots" }
            };
            contentsOfVM.Add(4, "skittles");
            contentsOfVM[8] = "skittles";

            //changing values

            string item = contentsOfVM[8];
            contentsOfVM[8] = "KitKat";

            //remove
            bool didWeRemoveNotExists = contentsOfVM.Remove(555);
            bool didWeRemoveExists = contentsOfVM.Remove(4);

            //looping

            foreach (KeyValuePair<int, string> content in contentsOfVM)
            {
                Console.WriteLine($"Our vending machine has {content.Value} at slot {content.Key}");
            }

            //HashSet

            HashSet<string> coolProgrammingLanguages = new HashSet<string>();

            coolProgrammingLanguages.Add("C#");
            coolProgrammingLanguages.Add("C#"); //unique values
            coolProgrammingLanguages.Add("c#");
            coolProgrammingLanguages.Add("python");
            coolProgrammingLanguages.Add("ruby");

            HashSet<string> weirdProgrammingLanguages = new HashSet<string>() { "javascript", "ruby" };

            //intersectsWith
            //coolProgrammingLanguages.IntersectWith(weirdProgrammingLanguages);
            //coolProgrammingLanguages = coolProgrammingLanguages;

            //unionWith
            //coolProgrammingLanguages.UnionWith(weirdProgrammingLanguages);
            //coolProgrammingLanguages = coolProgrammingLanguages;

            //exceptWith

            coolProgrammingLanguages.ExceptWith(weirdProgrammingLanguages);
            coolProgrammingLanguages = coolProgrammingLanguages;
        }
        //return type method name params??
        static bool ContainsKey(Dictionary<int, string> dictionaryToCheck, int keyToCheck)
        {
            //contentsofVM are out of scope
            return dictionaryToCheck.ContainsKey(keyToCheck);
        }
    }
}
