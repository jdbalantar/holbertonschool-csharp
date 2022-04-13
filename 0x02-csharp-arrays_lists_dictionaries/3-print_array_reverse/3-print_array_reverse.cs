using System;

namespace _3_print_array_reverse
{
    class Array
    {
        public static void Reverse(int[] array)
        {
            if(array == null || array.Length == 0)
                Console.Write('\n');
            else{
                for (int i = 0; i < array.Length; i++){
                    Console.Write(array[i]);
                    if (i < array.Length - 1)
                        Console.Write(' ');
                }
                Console.Write('\n');
            }
        }
    }
}
