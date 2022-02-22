namespace FizzBuzz;

public class FB_4_WorseThanNaive
{
    private static Boolean Fizz = false;
    private static Boolean Buzz = false;

    public static void Main(string[] args)
    {
        for (int number = 1 ; number <= 100 ; number++)
        {
            Fizz = number % 3 == 0;
            Buzz = number % 5 == 0;
            if (Fizz && Buzz)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (Fizz)
            {
                Console.WriteLine("Fizz");
            }
            else if (Buzz)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number.ToString());
            }
        }
    }
}
