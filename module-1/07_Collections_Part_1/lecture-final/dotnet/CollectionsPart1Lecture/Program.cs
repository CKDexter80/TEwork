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
			List<string> starTrekCharacters = new List<string>() { "Picard","Counselor Troi" };
			starTrekCharacters.Add("Spock");
			starTrekCharacters.Add("Worf");
			starTrekCharacters.Add("Data");



			//create a var of type       collection
			foreach (string starTrekCharacter in starTrekCharacters)
			{
				Console.WriteLine($"Character: { starTrekCharacter}");
			}


			Console.WriteLine("####################");
			Console.WriteLine("Lists are ordered");
			Console.WriteLine("####################");

			//lists are ordered and can be accessed by index
			// Console.WriteLine(starTrekCharacters[0]);

			for (int i = 0; i < starTrekCharacters.Count; i++)
			{
				Console.WriteLine($"For Character:  {starTrekCharacters[i]}");
			}

			Console.WriteLine("####################");
			Console.WriteLine("Lists allow duplicates? YES!");
			Console.WriteLine("####################");

			starTrekCharacters.Add("Spock");
			starTrekCharacters.Add("Dr McCoy");

			Console.WriteLine("####################");
			Console.WriteLine("Lists allow elements to be inserted in the middle");
			Console.WriteLine("####################");

			int starTrekCharactersHalfIndex = starTrekCharacters.Count / 2;
			starTrekCharacters.Insert(starTrekCharactersHalfIndex, "Captain Kirk");

			Console.WriteLine("####################");
			Console.WriteLine("Lists allow elements to be removed by index");
			Console.WriteLine("####################");

			starTrekCharacters.Remove("Spock");
			starTrekCharacters.RemoveAt(0);

			Console.WriteLine("####################");
			Console.WriteLine("Find out if something is already in the List");
			Console.WriteLine("####################");


			string characterToSearch = "Worf";
			//starTrekCharacters.Contains("Kirk");
			if (starTrekCharacters.Contains(characterToSearch))
			{
				Console.WriteLine($"{characterToSearch} IS in the List");
			}
			else
			{
				Console.WriteLine($"{characterToSearch} IS NOT in the List");
			}
			
			Console.WriteLine("####################");
			Console.WriteLine("Find index of item in List");
			Console.WriteLine("####################");

            Console.WriteLine($"Worf is at index {starTrekCharacters.IndexOf("Worf")}");
			
			Console.WriteLine("####################");
			Console.WriteLine("Lists can be turned into an array");
			Console.WriteLine("####################");

			string[] starTrekCharactersArray = starTrekCharacters.ToArray();

            foreach (string starTrekCharacter in starTrekCharactersArray)
            {
                Console.WriteLine($"Star Trek Character: {starTrekCharacter}");
            }

			Console.WriteLine("####################");
			Console.WriteLine("Lists can be sorted");
			Console.WriteLine("####################");

			//List<string> newStarTrekCharacters = new List<string>();
			//starTrekCharacters.CopyTo(newStarTrekCharacters);

			starTrekCharacters.Sort();
			starTrekCharacters = starTrekCharacters;

			Console.WriteLine("####################");
			Console.WriteLine("Lists can be reversed too");
			Console.WriteLine("####################");

			starTrekCharacters.Reverse();
			//put back in original order
			starTrekCharacters.Reverse();


			Console.WriteLine("####################");
			Console.WriteLine("       FOREACH");
			Console.WriteLine("####################");
			Console.WriteLine();

            foreach (string character in starTrekCharacters)
            {
				//printing list reverese alpha
				//DO NOT MODIFY AS YOU ITERATE
                Console.WriteLine(character);
            }


			//queue FIFO
			//ticketing system - call center
			//Kings Island line
			//produce
			//List<string> starTrekCharacters = new List<string>()
			Queue<string> line = new Queue<string>();
			line.Enqueue("Person 1 in Line");
			line.Enqueue("Person 2 in Line");
			line.Enqueue("Last Person in Line");
            Console.WriteLine($"Our line has {line.Count} people waiting");
			string person = line.Dequeue();
			Console.WriteLine($"Our line has {line.Count} people waiting after DQ");
			Console.WriteLine($"{person} got out of queue");
            Console.WriteLine($"{line.Peek()} is next in line");

			//stack LIFO
			//tennis balls - pringles out of container
			//undo button - browser back button
			//uhaul track

			Stack<string> websites = new Stack<string>();
			websites.Push("google.com");
			websites.Push("truestartrekkiesfanclub.com");
			websites.Push("youtube.com");

			string mostRecentWebsite = websites.Pop();
            Console.WriteLine($"You most recently visited: {mostRecentWebsite}");
			string nextWebsite = websites.Peek();
            Console.WriteLine($"Next up is {nextWebsite} and there are {websites.Count} left in stack");


		}
	}
}
