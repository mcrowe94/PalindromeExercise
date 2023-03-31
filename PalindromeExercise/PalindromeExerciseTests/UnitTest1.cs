using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        // Test Data Area
        [Theory]
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData("racecar", true)]
        [InlineData("tacocat", true)]
        [InlineData("monica", false)]
        //[InlineData("Was it a cat I saw", true)] //this method is in the LINQ method in the WordSmith class
        //[InlineData("never odd or even", true)] //LINQ method is commented out as well
        public void PalindromeTester(string word, bool expected)
        {
            //Arrage
            WordSmith tester = new WordSmith();

            //Act
            var actual = tester.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
