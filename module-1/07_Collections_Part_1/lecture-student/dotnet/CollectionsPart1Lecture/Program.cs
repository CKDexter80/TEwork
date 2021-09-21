using System;
using System.Collections.Generic;

namespace CollectionsPart1Lecture
{
    public class CollectionsPart1Lecture
	{
        static void Main(string[] args)
        {
			Console.WriteLine("####################");
			Console.WriteLine("       LISTS");
			Console.WriteLine("####################");
			//
			List<string> starTrekCharacters = new List<string>() { "Picard", "Counselor Troi"};
			starTrekCharacters.Add("Spock");
			starTrekCharacters.Add("Worf");
			starTrekCharacters.Add("Data");

            //Console.WriteLine(starTrekCharacters[0]);

            for (int i = 0; i < starTrekCharacters.Count; i++)
            {
				Console.WriteLine(starTrekCharacters[i]);
			}

					//create a var of type		collection
            foreach (string starTrekCharacer in starTrekCharacters)
            {
                Console.WriteLine($"Character: {starTrekCharacer}");
            }

			
			Console.WriteLine("####################");
			Console.WriteLine("Lists are ordered");
			Console.WriteLine("####################");

			


			Console.WriteLine("####################");
			Console.WriteLine("Lists allow duplicates");
			Console.WriteLine("####################");

			starTrekCharacters.Add("Spock");
			starTrekCharacters.Add("Dr. McCoy");

			Console.WriteLine("####################");
			Console.WriteLine("Lists allow elements to be inserted in the middle");
			Console.WriteLine("####################");

			int starTrekCharactersHalfIndex = starTrekCharacters.Count / 2;
			starTrekCharacters.Insert(starTrekCharactersHalfIndex, "Captain Kirk");

			Console.WriteLine("####################");
			Console.WriteLine("Lists allow elements to be removed by index");
			Console.WriteLine("####################");

			starTrekCharacters.Remove("Spock");

			Console.WriteLine("####################");
			Console.WriteLine("Find out if something is already in the List");
			Console.WriteLine("####################");

			string characterToSearch = "Worf";
			if (starTrekCharacters.Contains(characterToSearch))
			{
				Console.WriteLine($"{characterToSearch} IS in the list");
			}
            Console.WriteLine($"{characterToSearch} IS NOT in the list");

			Console.WriteLine("####################");
			Console.WriteLine("Find index of item in List");
			Console.WriteLine("####################");

			
            Console.WriteLine($"Worf is at index {starTrekCharacters.IndexOf("Worf")}");

			Console.WriteLine("####################");
			Console.WriteLine("Lists can be turned into an array");
			Console.WriteLine("####################");

			string[] starTrekCharactersArray = starTrekCharacters.ToArray();

            foreach (string starTrekCharater in starTrekCharactersArray)
            {
                Console.WriteLine($"Star Trek Character: {starTrekCharater}");
            }
			
			Console.WriteLine("####################");
			Console.WriteLine("Lists can be sorted");
			Console.WriteLine("####################");

			//uses default sorting algorithm (alphabetical, numerical)
			//can't be undone
			starTrekCharacters.Sort();


			Console.WriteLine("####################");
			Console.WriteLine("Lists can be reversed too");
			Console.WriteLine("####################");

			starTrekCharacters.Reverse();
			// back in original order
			starTrekCharacters.Reverse();

			Console.WriteLine("####################");
			Console.WriteLine("       FOREACH");
			Console.WriteLine("####################");
			Console.WriteLine();

			//queue FIFO
			//ticketing system - call center
			//Kings Island line
			//produce
			//
			Queue<string> line = new Queue<string>();
			line.Enqueue("Person 1 in line");
			line.Enqueue("Person 2 in line");
			line.Enqueue("Person 3 in line");

            Console.WriteLine($"Our line has {line.Count} people waiting");
			string person = line.Dequeue();

			Console.WriteLine($"Our line has {line.Count} people waiting");
            Console.WriteLine($"{person} has left the queue");
            Console.WriteLine($"{line.Peek()} is next in line");

			//stack LIFO
			//something that can be undone - browser back, text undone
			//uhaul truck
			//
			Stack<string> websites = new Stack<string>();
			websites.Push("google.com");
			websites.Push("reddit.com");
			websites.Push("youtube.com");

			string mostRecentWebsite = websites.Pop();
            Console.WriteLine($"You most recently visited: {mostRecentWebsite}");
			string nextWebsite = websites.Peek();
            Console.WriteLine($"Next up is {nextWebsite} and there are {websites.Count} left in the stack.");
		}
	}
}
