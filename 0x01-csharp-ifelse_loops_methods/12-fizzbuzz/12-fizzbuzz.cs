﻿using System;

namespace _12_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

        for (n = 1; n <= 100; n ++)
        {
            if (n % 3 == 0 && n % 5 == 0)
                Console.Write("FizzBuzz");
            else if (n % 3 == 0)
                Console.Write("Fizz");
            else if (n % 5 == 0)
                Console.Write("Buzz");
            else
                Console.Write("{0}", n);
            if (n <= 99)
                Console.Write(" ");
            else
                Console.Write("\n");
        }
        }
    }
}
