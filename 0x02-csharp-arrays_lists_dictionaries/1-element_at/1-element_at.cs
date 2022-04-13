using System;

namespace _1_element_at
{
    class Array
    {
        public static int elementAt(int[] array, int index){
            int element = 0;
            if (index >= array.Length || index < 0){
                Console.WriteLine("Index out of range");
                return -1;
                }
            else {
                for (int i = 0; i < array.Length; i++){
                    if (array[i] == array[index])
                    {
                        element = array[i];
                        break;
                    }
                }
                return element;
            }
        }
    }
}
