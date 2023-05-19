using System;
using Xunit;
using PalindromeExercise;
public class UnitTest1
{
    [Theory]
    [InlineData("racecar", true)]
    [InlineData("hello" , false)]
    [InlineData("Racecar" , true)]
    public void MyTest(string word, bool expected)
    {
        var tester = new WordSmith();

        var actual = tester.IsPalindrome(word);

        Assert.Equal(expected, actual);

    }
}
