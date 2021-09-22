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
            //vending machine item
                      //key //value
            Dictionary<int, string> contentsOfVM = new Dictionary<int, string>()
            {         //keypad code what snack is at that location
                    { 512, "cheetos" },
                    { 1024, "flaming hots" }
            };
            //adding 

            contentsOfVM.Add(4, "Skittles");
            contentsOfVM.Add(8, "Skittles");

            bool containsFour = contentsOfVM.ContainsKey(4);
            // //could be re-written as our own method
            //if (ContainsKey(contentsOfVM,4))
            //{
            //    //
            //}
            //else
            //{
            //    //
            //}


            //removing

            bool didWeRemoveNotExists = contentsOfVM.Remove(555);
            bool didWeRemoveExists = contentsOfVM.Remove(4);

            //looping
            foreach (KeyValuePair<int, string> content in contentsOfVM)
            {
                Console.WriteLine($"Our Vending Machine has {content.Value} at slot {content.Key}");
            }

            //        8  not an index but a key
            string item = contentsOfVM[8];

            //changing values
            contentsOfVM[8] = "KitKat";
            item = contentsOfVM[8];

            bool doWeHaveSkittles = contentsOfVM.ContainsValue("Skittles");

            //HashSet

            HashSet<string> coolProgammingLanguages = new HashSet<string>();
            coolProgammingLanguages.Add("C#");
            coolProgammingLanguages.Add("C#");//unique values
            coolProgammingLanguages.Add("c#");//unique values
            coolProgammingLanguages.Add("python");
            coolProgammingLanguages.Add("ruby");

            HashSet<string> weirdProgrammingLanguages =  new HashSet<string>() { "javascript","ruby" };

            //intersectwith
            //coolProgammingLanguages.IntersectWith(weirdProgrammingLanguages);
            //coolProgammingLanguages = coolProgammingLanguages;
            //unionwith
            //  coolProgammingLanguages.UnionWith(weirdProgrammingLanguages);
            // coolProgammingLanguages = coolProgammingLanguages;
            //exceptwith
            coolProgammingLanguages.ExceptWith(weirdProgrammingLanguages);
            coolProgammingLanguages = coolProgammingLanguages;

        }
        //return type method name params??
        static bool ContainsKey(Dictionary<int, string> dictionaryToCheck, int keyToCheck)
        {
            //contentsOfVM are out of scope
            bool containsKey = false;
            if (dictionaryToCheck.ContainsKey(keyToCheck))
            {
                containsKey = true;
            }

            return containsKey;
   
        }
    }
}
