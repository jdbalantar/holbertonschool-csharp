using System;

namespace _11_print_diagonal
{
    class Line
    {
        public static void PrintDiagonal(int length){
            int space = 0;

            for(int i = 0; i < length; i++){
                for (var j = 0; j < length; j++)
                {
                    Console.WriteLine("\\");
                }
                
            }
        }
    }
}
