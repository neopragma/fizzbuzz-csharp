namespace FizzBuzz;

public class FB_2_BruteForce
{
    public static void Main(string[] args)
    {
        int number = 1;
        while (number <= 100)
        {
            Console.WriteLine(number % 15 == 0 ? "FizzBuzz" : number % 5 == 0 ? "Buzz" : number % 3 == 0 ? "Fizz" : number);
            number++;    
        }
    }
}
