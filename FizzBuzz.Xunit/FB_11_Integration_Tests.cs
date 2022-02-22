using System;
using System.IO;
using Xunit;

namespace FizzBuzz.Xunit;

public class FB_11_Integration_Tests
{
    [Theory]
    [Trait("Category", "Integration")]
    [InlineData(new string[] {}, "Two args required: Lower and upper bound of numbers to percolate.")]
    [InlineData(new string[] { "A", "2" }, "Arguments must be numeric. Found A, 2.")]
    [InlineData(new string[] { "4", "B" }, "Arguments must be numeric. Found 4, B.")]
    [InlineData(new string[] { "XXX", "YYY" }, "Arguments must be numeric. Found XXX, YYY.")]
    [InlineData(new string[] { "0", "100" }, "Lower bound must be in the range 1 through 99 inclusive. Found 0.")]
    [InlineData(new string[] { "100", "100" }, "Lower bound must be in the range 1 through 99 inclusive. Found 100.")]
    [InlineData(new string[] { "1", "1" }, "Upper bound must be in the range 2 through 100 inclusive. Found 1.")]
    [InlineData(new string[] { "1", "101" }, "Upper bound must be in the range 2 through 100 inclusive. Found 101.")]
    [InlineData(new string[] { "55", "44" }, "Upper bound must be greater than lower bound. Found 55, 44.")]
    public void it_throws_when_wrong_number_of_arguments_is_passed(string[] args, string expectedMessage)
    {
        var exception = Assert.Throws<ArgumentException>(() =>
            Driver.Main(args)
        );
        Assert.Equal(expectedMessage,  exception.Message);    
    }

    [Fact]
    [Trait("Category", "Integration")]
    public void it_writes_the_list_to_the_console()
    {
        string expectedResult = "1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz\n11\nFizz\n13\n14\nFizzBuzz\n16\n17\nFizz\n19\nBuzz\n";
        StringWriter fakeConsole = new StringWriter();
        Console.SetOut(fakeConsole);
        Driver.Main(new string[] { "1", "20" });
        Assert.Equal(expectedResult, fakeConsole.ToString());
    }
}
