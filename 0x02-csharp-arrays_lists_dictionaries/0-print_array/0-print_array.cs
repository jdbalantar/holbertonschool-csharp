using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        int[] array = new int[size];

        if (size == 0)
        {
            Console.Write('\n');
            return array;
        }

        for (int i = 0; i < size; i++)
            array[i] = i;

        Console.WriteLine("{0}", String.Join(" ", array));
        return array;
    }
}
