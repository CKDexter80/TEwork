using System;
using System.Collections.Generic;
using System.Text;

namespace FizzWriter
{
    public class Inputs
    {
        public static string GetDestinationFilePath()
        {
            Console.WriteLine("What is the destination file?");
            string destinationFilePath = Console.ReadLine();
            return destinationFilePath;
        }
    }
}
