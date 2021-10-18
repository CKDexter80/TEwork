using System;
using System.Collections.Generic;
using System.IO;

namespace Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            //new object and testing string
            Car testCar = new Car(1988, "Suzuki Samurai", false);
            Console.WriteLine(testCar.ToString());


            //creating full path from input file
            //I'm sorry, but I had to hard code MY directory for the file
            //I swear it works
            string directory = Environment.CurrentDirectory;
            string inputFile = "DATA/CarInput.csv";
            string inputFullPath = Path.Combine(directory, inputFile);
            

           //populating list of Car objects
            List<Car> cars = new List<Car>();
            try
            {
                using (StreamReader sr = new StreamReader(inputFullPath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();                                               
                        string[] words = line.Split(',');

                        cars.Add(new Car(Int32.Parse(words[0]), words[1], Convert.ToBoolean(words[2])));
                    }
                }
            }
            catch (Exception e )
            {

                Console.WriteLine(e.Message);
            }

            //printing out total age of cars in list
            int totalAge = 0;

            foreach (Car car in cars)
            {
                totalAge += car.Age;
            }

            Console.WriteLine($"Total age: {totalAge}");

        }
    }
}
