using System;

class Array
{
    public static int elementAt(int[] array, int index)
    {
        if (index < 0 || index >= array.Length)
            return -1;
        int size = array.Length, value = 0;

        for (var i = 0; i < size; i++)
        {
            if (array[i] == array[index])
                value = array[index];
        }
        return (value);
    }
}