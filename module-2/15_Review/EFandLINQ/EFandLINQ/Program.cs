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
      
        }
    }

    class Student
    {
       public string StudentName { get; set; }
       public int StudentID { get; set; }
       public int Age { get; set; }
    }
}
