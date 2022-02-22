﻿namespace FB_6_Enumerable;

// Sample solution from rosettacode.org 
public class FB_6_Enumerable
{
    static void Main(string[] args)
    {
        Enumerable.Range(1, 100)
            .Select(a => String.Format("{0}{1}", a % 3 == 0 ? "Fizz" : string.Empty, a % 5 == 0 ? "Buzz" : string.Empty))
            .Select((b, i) => String.IsNullOrEmpty(b) ? (i + 1).ToString() : b)
            .ToList()
            .ForEach(Console.WriteLine);
    }
}
