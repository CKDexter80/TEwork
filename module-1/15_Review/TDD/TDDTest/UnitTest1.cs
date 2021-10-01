using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD;

namespace TDDTest
{
    [TestClass]
    public class UnitTest1
    {

        /*
         * 
         * divisible 3 => Fizz
         * divisible 5 => Buzz
         * divisible 3 AND 5 FizzBuzz
         * everything else number tostring
         */
        [TestMethod]
        [DataRow(3, "Fizz")]
        [DataRow(5, "Buzz")]
        public void FizzOrBuzz(int parameterToTest, string expected)
        {
            //arrange
            FizzBuzz fb = new FizzBuzz();
            
            //act
            string actual = fb.SolveFizzBuzz(parameterToTest);

            //assert

            Assert.AreEqual(expected, actual, "Do not give me nulls");

        }

        [TestMethod]
        [DataRow(15, "FizzBuzz")]
        [DataRow(30, "FizzBuzz")]
        public void FizzBuzz(int parameterToTest, string expected)
        {
            //arrange
            FizzBuzz fb = new FizzBuzz();

            //act
            string actual = fb.SolveFizzBuzz(parameterToTest);

            //assert

            Assert.AreEqual(expected, actual, "Is not FizzBuzz");

        }

        [TestMethod]
        [DataRow(7, "7")]
        [DataRow(13, "13")]
        public void NotFizzBuzzOrFizzBuzz(int parameterToTest, string expected)
        {
            //arrange
            FizzBuzz fb = new FizzBuzz();

            //act
            string actual = fb.SolveFizzBuzz(parameterToTest);

            //assert
            
            Assert.AreEqual(expected, actual, "Is not original");

        }
    }
}
