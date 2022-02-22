using System.Collections.Generic;
using Xunit;
using FluentAssertions;

namespace FizzBuzz.Xunit;

public class FB_11_Xunit_Fluent_Tests
{
    private Bubbler subject;
    public FB_11_Xunit_Fluent_Tests()
    {
        subject = new Bubbler();
    }
    
    [Fact]
    [Trait("Category", "Unit")]
    public void it_returns_result_list_for_numbers_1_through_20()
    {
        IList<string> expected = new List<string> 
        { 
            "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz",
            "11", "Fizz", "13", "14", "FizzBuzz", "16", "17", "Fizz", "19", "Buzz"
        };
        subject.FizzMyBuzz((1, 20)).Should().Equal(expected);
    }

}
