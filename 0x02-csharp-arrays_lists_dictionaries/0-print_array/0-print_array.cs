using System;

namespace _0_print_array
{
    class Arrreglo
    {
        public static int[] CreatePrint(int size){
            if(size == 0)
                Console.Write('\n');
            if(size < 0){
                Console.WriteLine("Size cannot be negative");
                return null;
            }
            else{
                int[] array = new int[size];
                for (int i = 0; i < size; i++)
                {
                    array[i] = i;
                    if (i != size - 1)
                        Console.Write($"{array[i]} ");
                    else
                        Console.Write($"{array[i]}");
                }
                Console.WriteLine();
                return array;
            }
        }
    } 
}
