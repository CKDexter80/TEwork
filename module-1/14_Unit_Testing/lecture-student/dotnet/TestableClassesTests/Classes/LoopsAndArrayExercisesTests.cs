using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestableClasses.Classes.Tests
{
    [TestClass()]
    public class LoopsAndArrayExercisesTests
    {
        //CollectionAssert
        //.AllItemsAreNotNull() - Looks at each item in actual collection for not null
        //.AllItemsAreUnique() - Checks for uniqueness among actual collection
        //.AreEqual() - Checks to see if two collections are equal (same order and quantity)
        //.AreEquilavent() - Checks to see if two collections have same element in same quantity, any order
        //.AreNotEqual() - Opposite of AreEqual
        //.AreNotEquilavent() - Opposite or AreEqualivent
        //.Contains() - Checks to see if collection contains a value/object


        [TestMethod]
        public void MiddleWay()
        {
            /*
                *Arrange
                *Act
                *Assert
            */
            // arrange
            LoopsAndArrayExercises loopsAndArrayExercises = new LoopsAndArrayExercises();
            int[] firstParameter = { 1, 2, 3 };
            int[] secondParameter = { 4, 5, 6 };

            //act
            int[] actual =  loopsAndArrayExercises.MiddleWay(firstParameter, secondParameter);
            int[] expected = { 2, 5 };
            //assert
            CollectionAssert.AreEqual(expected, actual, "returned wrong numbers");
        }

        [TestMethod]
        public void MaxEndThree()
        {
            //arrange
            LoopsAndArrayExercises loopsAndArrayExercises = new LoopsAndArrayExercises();

            //act
            int[] a = { 1, 2, 3 };
            int[] actual = loopsAndArrayExercises.MaxEnd3(a);
            int[] expected = { 3, 3, 3 };

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }


    }
}