namespace FizzBuzz;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
public class FB_10_Delegates
{
    private delegate string Buzzer(int number);
    private readonly IList<Buzzer> _functions = new List<Buzzer>();

    public FB_10_Delegates()
    {
        _functions.Add(x => x % 3 == 0 ? "Fizz" : "");
        _functions.Add(x => x % 5 == 0 ? "Buzz" : "");
    }

    public string Percolate(int number
    )
    {
        var result = _functions.Aggregate(String.Empty, (current, function) => 
            current + function.Invoke(number));
        return String.IsNullOrEmpty(result) 
            ? number.ToString(CultureInfo.InvariantCulture) 
            : result;
    }

    public static void Main(string[] args)
    {
        FB_10_Delegates percolator = new FB_10_Delegates();
        Enumerable.Range(1, 100)
            .Select(x => 
                percolator
                    .Percolate(x))
                    .ToList()
                    .ForEach(result => Console.WriteLine(result));
    }
}
