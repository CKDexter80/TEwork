using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;


namespace Assessment.Tests
{
    [TestClass]
    
    public class AgeOfCarTest
    {
        [TestMethod]
        public void AgeOfCar()
        {
            Assessment.Car c = new Assessment.Car(1975, "Chevrolet", true);

            int expected = 46;
            int actual = c.Age;

            Assert.AreEqual(expected, actual);
            
        }
    }
}
