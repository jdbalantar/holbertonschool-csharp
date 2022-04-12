using System;

namespace _11_print_diagonal
{
    class Line
    {
        public static void PrintDiagonal(int length){
            int i, j;

            for (i = 0; i < length; i++)
            {
                for (j = 0; j < length; j++)
                {
                    if (i > j)
                        Console.Write(" ");
                }
                Console.Write("\\");
                Console.Write("\n");
            }
        }
    }
}
