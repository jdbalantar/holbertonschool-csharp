using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        string str = ($"The last digit of {number} is {number % 10}");
        if(number % 10 > 5)
            Console.WriteLine($"{str} and is greater than 5");
        if((number % 10 < 6) && (number != 10))
            Console.WriteLine($"{str} and is less than 6 and not 0");
        if(number % 10 == 0)
            Console.WriteLine($"{str} and is 0");
    }
}