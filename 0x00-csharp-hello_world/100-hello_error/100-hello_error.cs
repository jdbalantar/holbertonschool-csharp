using System;

class Program
{
	static void Main(string[] args)
	{
		var error = Console.Error;
        string str = "and that piece of art is useful - Dora Korpar, 2015-10-19";
		error.WriteLine(str);
		System.Environment.Exit(1);
    }
}