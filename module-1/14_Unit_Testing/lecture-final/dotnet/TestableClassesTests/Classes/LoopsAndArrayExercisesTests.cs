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
        public void MiddleWayTest()
        {
            /*
             * Arrange
             * Act
             * Assert
             */
            // ARRANGE
            LoopsAndArrayExercises loopsAndArrayExercises = new LoopsAndArrayExercises();
            int[] firstParameter = { 1, 2, 3 };
            int[] secondParameter = { 4, 5, 6 };
   
            ///ACT
            int[] actual = loopsAndArrayExercises.MiddleWay(firstParameter, secondParameter);
            int[] expected = { 2, 5 };
            
            //ACT
            CollectionAssert.AreEqual(expected, actual, "should return the middle element, tyson");
        }

        [TestMethod]
        public void MaxEndThreeLastNumberIsLargest()
        {
            //Arrange
            LoopsAndArrayExercises loopsAndArrayExercises = new LoopsAndArrayExercises();
            /*       
         maxEnd3([1, 2, 3]) → [3, 3, 3]

             */
            int[] a = { 1, 2, 3 };
            //ACT
            int[] actual = loopsAndArrayExercises.MaxEnd3(a);
            int[] expected = { 3, 3, 3 };

            //ASSERT
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void MaxEndThreeFirstNumberIsLargest()
        {
            //Arrange
            LoopsAndArrayExercises loopsAndArrayExercises = new LoopsAndArrayExercises();
            /*       
        maxEnd3([11, 5, 9]) → [11, 11, 11]
             */
            int[] a = { 11, 5, 9 };
            //ACT
            int[] actual = loopsAndArrayExercises.MaxEnd3(a);
            int[] expected = { 11, 11, 11 };

            //ASSERT
            CollectionAssert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void MaxEndThreeFirstNumberTwoTimes()
        {
            //Arrange
            LoopsAndArrayExercises loopsAndArrayExercises = new LoopsAndArrayExercises();

            int[] a = { 11, 5, 9 };
            //ACT
            int[] actual = loopsAndArrayExercises.MaxEnd3(a);
            int[] expected = { 11, 11, 11 };
            //ASSERT
            CollectionAssert.AreEqual(expected, actual,"first one failed");

            int[] a2 = { 12,11,3 };
            int[] actual2 = loopsAndArrayExercises.MaxEnd3(a2);
            int[] expected2 = { 12, 12, 12 };
            CollectionAssert.AreEqual(expected2, actual2,"Second one failed");
        }
        //class body
    }
    //danger zone
}