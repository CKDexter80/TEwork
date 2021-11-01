using System;
using System.Linq;
using EFandLINQ.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFandLINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("yo");
            string s = "";
            int x = 3;
            

            var numbers = new List<int> { 1, 3, 4, 7, 8, 9, 10, 20 };

            var LargestNumber = numbers.Max();
            var AverageOfNumber = numbers.Average();

            var overTen = numbers.FirstOrDefault(n => n > 10000);
            IEnumerable<int> allNumbersOverTen = numbers.Where(n => n > 10).ToList();
            IEnumerable<int> allNumbersUnderTen = numbers.Where(n => n < 10);
            allNumbersOverTen = allNumbersOverTen;

            Student[] students = { 
                new Student(){ StudentID = 1, Age= 10, StudentName="joe"},
                new Student(){ StudentID = 2, Age= 20, StudentName="tyson"},
                new Student(){ StudentID = 3, Age= 30, StudentName="levi"},
                new Student(){ StudentID = 4, Age= 40, StudentName="bq"},
            };

            List<Student> studentsUnderTwentyOne = students.Where(s => (s.Age <= 21)).ToList(); ;
            studentsUnderTwentyOne = studentsUnderTwentyOne;

            var dbContext = new UnitedStatesContext();
            IEnumerable<City> cities = dbContext.Cities.Where(c => c.CityName.Contains("C"));
            List<City> showCities = cities.ToList();
            showCities = showCities;

            var citiesInOhio = dbContext.States.Include("Cities").Where(s => s.StateAbbreviation == "OH").ToList();
            citiesInOhio = citiesInOhio;

            var averagePopulation = dbContext.States.Average(s => s.Population);


            var city = new City { CityName="JOE",Area=1, Population=2, StateAbbreviation="KY"};
            dbContext.Cities.Add(city);
       
            int recordsSaved = dbContext.SaveChanges();

        }
    }

    class Student
    {
       public string StudentName { get; set; }
       public int StudentID { get; set; }
       public int Age { get; set; }
    }
}
