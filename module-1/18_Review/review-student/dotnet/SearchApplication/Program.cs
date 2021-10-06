using SearchApplication.Search;
using SearchApplication.Util;
using System;
using System.Collections.Generic;

namespace SearchApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Step Two: Create TELog, and log the start of the application.
                //
                TELog.Log("Search application started");


                // Step Four: Instantiate a Search Domain
                //

                SearchDomain sd = new SearchDomain("data");
                TELog.Log(sd.ToString());

                // Step Six: Single word search
                //
                //SearchEngine se = new SearchEngine(sd);
                //se.IndexFiles();
                //IList<string> searchResults = se.Search("tootie");

                //if (searchResults.Count == 0)
                //{
                //    Console.WriteLine("No files found");
                //}
                //else
                //{
                //    foreach (string result in searchResults)
                //    {
                //        Console.WriteLine(result);
                //    }
                //}




                // Step Seven: Multiple word search
                //
                SearchEngine se = new SearchEngine(sd);
                se.IndexFiles();
                IList<string> searchResults = se.Search("telephone line");

                if (searchResults.Count == 0)
                {
                    Console.WriteLine("No files found");
                }
                else
                {
                    foreach (string result in searchResults)
                    {
                        Console.WriteLine(result);
                    }
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("General exception occurred:\n" + ex.StackTrace);
            }
        }
    }
}
