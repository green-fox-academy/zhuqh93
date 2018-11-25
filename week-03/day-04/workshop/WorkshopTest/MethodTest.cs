using System;
using System.Collections.Generic;
using workshop;
using Xunit;

namespace WorkshopTest
{
    public class MethodTest
    {
        [Fact]
        public void PrintAppleString()
        {
            //arrange
            string expectedOutput = "apple";
            var appleTest = new Apple();

            //act
            string actualOutput = appleTest.GetApple();

            //assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void SumIntegerInList()
        {
            //arrange
            List<int> testList = new List<int>{ 1, 2, 3, 4, 5, 6};
            List<int> emptyList = new List<int>();
            List<int> singleElementList = new List<int> { 1000 };
            //null list doesn't work.
            //List<int> nullList = new List<int> {null}; 

            int expectedOutput = 21;
            var sumTest = new Sum();

            //act
            int actualOutput = sumTest.SumInt(testList);

            //assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void AreTheseStringsAnagram()
        {
            //arrange
            string testString1 = "apple";
            string testString2 = " pa PeL ";

            var anagramTest = new Anagram();

            //act
            bool actualOutput = anagramTest.IsAnagramms(testString1, testString2);

            //assert
            Assert.True(actualOutput);
        }

        [Fact]
        public void CountLetterApperanceCorrectly()
        {
            //arrange
            string testString = "abcdeaaabbcd";
            Dictionary<char, int> expectedOutput = new Dictionary<char, int>
            {
                {'a', 4},
                {'b', 3},
                {'c', 2},
                {'d', 2},
                {'e', 1}
            };
            var countLetters = new CountLetters();

            //act
            Dictionary<char, int> actualOutput = countLetters.CountLetter(testString);

            //assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void ComputeAFibonacciNumberByIndex()
        {
            //arrange
            int testIndex = 5;
            int expectedOutput = 3;
            var computeFibonacci = new Fibonacci();

            //act
            int actualOutput = computeFibonacci.generateFibonacci(testIndex);

            //assert
            Assert.Equal(expectedOutput, actualOutput);
        } 
    }
}
