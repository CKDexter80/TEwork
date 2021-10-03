using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class WordCountTest
    {
        [TestMethod]
        public void GetCountUsingLowerCaseStrings()
        {
            WordCount wordCount = new WordCount();

            string[] input = { "ba", "ba", "black", "sheep" };
            Dictionary<string, int> expected = new Dictionary<string, int>
            {
                {"ba", 2 },
                {"black", 1 },
                {"sheep", 1 }
            };
            Dictionary<string, int> actual = wordCount.GetCount(input);

            CollectionAssert.AreEqual(expected, actual);

            string[] inputA = { "a", "b", "a", "c", "b" };
            Dictionary<string, int> expectedA = new Dictionary<string, int>
            {
                {"a", 2 },
                {"b", 2 },
                {"c", 1 }
            };
            Dictionary<string, int> actualA = wordCount.GetCount(inputA);

            CollectionAssert.AreEqual(expectedA, actualA);

            string[] inputB = { "c", "b", "a" };
            Dictionary<string, int> expectedB = new Dictionary<string, int>
            {
                { "c", 1 },
                { "b", 1 },
                { "a", 1 }
            };
            Dictionary<string, int> actualB = wordCount.GetCount(inputB);

            CollectionAssert.AreEqual(expectedB, actualB);
        }

        [TestMethod]
        public void GetCountUsingEmptyArray()
        {
            WordCount wordCount = new WordCount();

            string[] input = { };
            Dictionary<string, int> expected = new Dictionary<string, int> { };

            Dictionary<string, int> actual = wordCount.GetCount(input);

            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void GetCountUsingStringsWithMixedCases()
        {
            WordCount wordCount = new WordCount();

            string[] input = { "Hi", "How", "how", "Hi" };
            Dictionary<string, int> expected = new Dictionary<string, int> {
                { "Hi", 2 },
                { "How", 1 },
                { "how", 1 }
            };

            Dictionary<string, int> actual = wordCount.GetCount(input);

            CollectionAssert.AreEqual(expected, actual);

        }
    }
}
