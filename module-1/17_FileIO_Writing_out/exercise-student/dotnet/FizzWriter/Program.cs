using System;

namespace FizzWriter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string destinationFilePath = Inputs.GetDestinationFilePath();

            FizzBuzzWriter.FizzBuzzWriting(destinationFilePath);
        }
    }
}
