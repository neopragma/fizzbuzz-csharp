namespace FizzBuzz;
public class FB_8_Switch
{
    public static string Percolate(int number) =>
        (number % 3, number % 5) switch
        {
            (0, 0) => "FizzBuzz",
            (0, _) => "Fizz",
            (_, 0) => "Buzz",
            (_, _) => $"{number}"
        };
 
    static void Main(string[] args)
    { 
        foreach (var number in Enumerable.Range(1, 100))
        {
            Console.WriteLine(Percolate(number));
        }
    }
}
