﻿using System;

class Program
{
	static void Main(string[] args)
	{
		double percent = .7553;
		double currency = 98765.4321;
		Console.Write(string.Format("{0:0.00%} ", percent));
		Console.WriteLine(string.Format("${0:0,00.00}", currency));
	}
}