using System;
using PalindromeExercise;
using Xunit;


namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        public void MyTest(string word, bool expected)
        {
            //arrange
            var tester = new WordSmith();

            //act
            var actual = tester.IsAPolindrome(word);
            //assert
            Assert.Equal(expected, actual);
        }

    }
}
