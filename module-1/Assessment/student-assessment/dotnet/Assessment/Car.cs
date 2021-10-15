using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment
{
    public class Car
    {
        public Car(int year, string make, bool isClassicCar)
        {
            Year = year;
            Make = make;
            IsClassicCar = isClassicCar;
        }

        public int Year { get; }
        public string Make { get; }
        public bool IsClassicCar { get; }

        public int Age
        {
            get
            {
                return DateTime.Today.Year - Year;
            }
        }

        public bool IsInNeedOfECheck (int yearToCheck)
        {
            if (IsClassicCar || Age < 4 || Age > 25)
            {
                return false;
            }
            else if (yearToCheck % 2 == 0 && Year % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"CAR - {Year} - {Make}";
        }
    }
}
