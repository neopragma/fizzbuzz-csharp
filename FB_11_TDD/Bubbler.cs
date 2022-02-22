namespace FizzBuzz;

using System.Collections.Generic;
using System.Linq;
public class Bubbler
{
    public IList<string> FizzMyBuzz((int start, int end) range)
    {
        IList<string> result = new List<string>();
        foreach (var number in Enumerable.Range(range.start, range.end))
        {
            result.Add(Percolate(number));
        }
        return result;
    }
    public string Percolate(int number) =>
        (number % 3, number % 5) switch
        {
            (0, 0) => "FizzBuzz",
            (0, _)  => "Fizz",
            (_, 0) => "Buzz",
            (_, _) => $"{number}"
        };
    // public string Percolate(int number) =>
    //     (number % 3, number % 5, number % 7) switch
    //     {
    //         (0, 0, 0) => "FizzBuzzBaz",
    //         (0, 0, _) => "FizzBuzz",
    //         (0, _, 0)  => "FizzBaz",
    //         (_, 0, 0) => "BuzzBaz",
    //         (0, _, _)  => "Fizz",
    //         (_, 0, _) => "Buzz",
    //         (_, _, 0) => "Baz",
    //         (_, _, _) => $"{number}"
    //     };
}
