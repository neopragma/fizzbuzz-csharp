namespace FizzBuzz; 

public class FB_5_Concatenation 
{
    public static void Main(string[] args)
    {
        for ( int number = 1 ; number <= 100 ; number++ )
        {
            string s = null;
            if (number % 3 == 0) s = "Fizz";
            if (number % 5 == 0) s += "Buzz";
            Console.WriteLine(s ?? number.ToString());
        }
    }
}
