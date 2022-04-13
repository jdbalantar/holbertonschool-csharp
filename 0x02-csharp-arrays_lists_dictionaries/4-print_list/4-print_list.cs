using System;
using System.Collections.Generic;

namespace _4_print_list
{
    class List
    {
        public static List<int> CreatePrint(int size)
        {
            if(size <= 0){
                Console.WriteLine("Size cannot be negative");
                return null;;
            }
            var NewList = new List<int>();
            for (int i = 0; i < size; i++){
                NewList.Add(i);
                Console.Write(NewList[i]);
                if(i != size - 1)
                    Console.Write(' ');
            }
            Console.WriteLine("");
            return NewList;
        }
    }
}
