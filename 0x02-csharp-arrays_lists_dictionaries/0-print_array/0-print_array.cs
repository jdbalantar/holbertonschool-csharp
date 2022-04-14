using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        int[] new_array;
        int i;

        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        new_array = new int[size];

        if (size == 0)
        {
            Console.Write("\n");
            return new_array;
        }

        for (i = 0; i < size; i++)
        {
            new_array[i] = i;
            Console.Write(new_array[i]);
            if (i < size - 1)
                Console.Write(" ");
                            
            
        }
        Console.Write("\n");
        return new_array;
    }
}