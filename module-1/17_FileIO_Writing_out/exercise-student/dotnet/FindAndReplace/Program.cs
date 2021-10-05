using System;

namespace FindAndReplace
{
    public class Program
    {
		public static void Main(string[] args)
		{
            string searchWord = Inputs.GetSearchWord();
            string replacementWord = Inputs.GetReplacementWord();
            string sourceFilePath = Inputs.GetSourceFilePath();
            string destinationFilePath = Inputs.GetDestinationFilePath();

            SearchReplace.SearchAndReplace(searchWord, replacementWord, sourceFilePath, destinationFilePath);
        }
    }
}
