namespace FizzBuzz; 

public class FB_3_Naive
{
    public static void Main(string[] args)
    {
        for (int number = 1 ; number <= 100 ; number++)
        {
            if ( number % 3 == 0 && number % 5 ==0 )
            {
                Console.WriteLine("FizzBuzz");
            }
            else if ( number % 5 == 0 )
            {
                Console.WriteLine("Buzz");
            }
            else if ( number % 3 == 0 )
            {
                Console.WriteLine("Fizz");
            }
            else
            {
                Console.WriteLine(number);
            }
        }
    }
}
