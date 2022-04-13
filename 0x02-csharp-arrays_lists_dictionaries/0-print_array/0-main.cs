using System;
using _0_print_array;

class Program
{
    static void Main(string[] args)
    {
        int[] newArray;

        newArray = Arreglo.CreatePrint(10);
        Console.WriteLine("Array Length: " + newArray.Length);
        Console.WriteLine("----------------");
        newArray = Arreglo.CreatePrint(16);
        Console.WriteLine("Array Length: " + newArray.Length);
        Console.WriteLine("----------------");
        newArray = Arreglo.CreatePrint(0);
        Console.WriteLine("Array Length: " + newArray.Length);
        Console.WriteLine("----------------");
        newArray = Arreglo.CreatePrint(-10);
    }
}