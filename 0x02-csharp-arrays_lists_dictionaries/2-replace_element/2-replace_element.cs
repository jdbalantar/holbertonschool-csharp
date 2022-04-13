using System;

namespace _2_replace_element
{
    class Array
    {
        public static int[] ReplaceElement(int[] array, int index, int n){
            if(index >= array.Length || index < 0){
                Console.WriteLine("Index out of range");
                return array;  
            } else {
                for(int i = index; i < array.Length; i++){
                    {
                        if(array[i] == array[index])
                        array[i] = n;
                        break;
                    }
                }
                return array;
            }
        }
    }
}
