using System;

namespace _0_print_array
{
    class Array
    {
        public static int[] CreatePrint(int size){
            if(size == 0)
                Console.Write('\n');
            if(size < 0){
                Console.WriteLine("Size cannot be negative");
                return null;
            }
                int[] array = new int[size];
                for (int i = 0; i < size; i++)
                {
                    array[i] = i;
                    Console.Write(array[i]);
                    if(i < size - 1)
                        Console.Write(' ');
                }
                Console.WriteLine();
                return array;
            
        }
    } 
}
