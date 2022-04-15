using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        int i;
        var temp = myLList.First;
        if (index >= myLList.Count || index < 0)
            return;
        for (i = 0; i < index; i++)
            temp = temp.Next;
        myLList.Remove(temp);
    }
}