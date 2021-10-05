using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace FizzWriter
{
    public class FizzBuzzWriter
    {
        public static void FizzBuzzWriting(string filePath)
        {

            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    for (int i = 1; i < 301; i++)
                    {
                        sw.WriteLine(FizzBuzz.FizzBuzzer(i));
                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message); 
            }

        }
    }
}
