using NUnit.Framework;

namespace FizzBuzz.MSTest;

using System.Collections.Generic;

public class FB_11_MSTest_Tests
{
    private Bubbler? subject;

    [SetUp]
    public void Setup()
    {
        subject = new Bubbler();
    }

    [Test]
    [Category("Unit")]
    public void it_returns_result_list_for_numbers_1_through_20()
    {
        IList<string> expected = new List<string> 
        { 
            "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz",
            "11", "Fizz", "13", "14", "FizzBuzz", "16", "17", "Fizz", "19", "Buzz"
        };
        Assert.AreEqual(expected, subject!.FizzMyBuzz((1, 20)));
    }
}