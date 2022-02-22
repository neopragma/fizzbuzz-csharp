namespace FizzBuzz;

using System;
using System.Linq;
public class Driver
{
    private static Bubbler app = new Bubbler();

    public static void Main(string[] args)
    {
        foreach (var value in app.FizzMyBuzz(ValidateArguments(args))) 
        {
            Console.WriteLine(value);
        }
    }

    private static (int lowerBound, int upperBound) ValidateArguments(string[] args)
    {
        if (args.Length != 2) 
            throw new ArgumentException("Two args required: Lower and upper bound of numbers to percolate.");
        if (!args[0].All(char.IsDigit) || !args[1].All(char.IsDigit)) 
            throw new ArgumentException(String.Format("Arguments must be numeric. Found {0}, {1}.", args[0], args[1]));
        var lowerBound = 0;    
        Int32.TryParse(args[0], out lowerBound);
        var upperBound = 0;
        Int32.TryParse(args[1], out upperBound);
        if (lowerBound < 1 || lowerBound > 99) 
            throw new ArgumentException(String.Format("Lower bound must be in the range 1 through 99 inclusive. Found {0}.", lowerBound));
        if (upperBound < 2 || upperBound > 100) 
            throw new ArgumentException(String.Format("Upper bound must be in the range 2 through 100 inclusive. Found {0}.", upperBound));
        if (upperBound <= lowerBound) 
            throw new ArgumentException(String.Format("Upper bound must be greater than lower bound. Found {0}, {1}.", lowerBound, upperBound));
        return (lowerBound: lowerBound, upperBound: upperBound);
    }
}
