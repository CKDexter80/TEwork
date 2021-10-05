using System;
using System.IO;


namespace WordSearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string fullPath = Inputs.FullPath();
            string search = Inputs.SearchForThis();
            bool isCaseSensitive = Inputs.IsCaseSensitive();

            if (isCaseSensitive)
            {
                CaseSensitive.caseSensitiveSearch(fullPath, search);
            }
            else
            {
                CaseInsensitive.caseInsensitiveSearch(fullPath, search);
            }

        }
    }
}
