using System;

namespace _0_print_array
{
    class Array
    {
        public static int[] CreatePrint(int size){
            
            if(size < 0){
                Console.WriteLine("Size cannot be negative");
                return null;
            }

            var array = new int[size];

            if(size == 0){
                Console.Write('\n');
                return array;
            }
                
            for (int i = 0; i < size; i++)
            {
                
                Console.Write(array[i]);
                if(i < size - 1)
                    Console.Write(' ');
                array[i] = i;
            }
            Console.WriteLine();
            return array;
            
        }
    } 
}
