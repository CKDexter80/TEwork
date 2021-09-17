using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the temperature: ");
            string temperature = Console.ReadLine();
            int temperatureNumber = int.Parse(temperature);

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Is the temperature in (C)elsius, or (F)ahrenheit? ");
            string temperatureCOrF = Console.ReadLine();
            string temperatureCOrFUpper = temperatureCOrF.ToUpper();

            Console.WriteLine();
            Console.WriteLine();

            if (temperatureCOrFUpper == "F")
            {
                Console.WriteLine(temperatureNumber + "F is " + ((temperatureNumber - 32) / 1.8) + "C.");
            } else if (temperatureCOrFUpper == "C")
            {
                Console.WriteLine(temperatureNumber + "C is " + ((temperatureNumber * 1.8) + 32) + "F.");
            }



        }
    }
}
