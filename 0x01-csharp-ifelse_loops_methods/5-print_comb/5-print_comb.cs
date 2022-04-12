using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 99; i++)
            {
                if(i < 10)
                    Console.Write($"0{i}");
                if(i >= 10)
                    Console.Write(i);
                if(i < 99)
                    Console.Write(", ");     
                else
                    Console.Write('\n');
            }
        }
    }
}
