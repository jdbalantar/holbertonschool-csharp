using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        var myList = new List<int>();
        foreach (int itemList1 in list1)
        {
            if (list2.Contains(itemList1))
                continue;
            else
                myList.Add(itemList1);
        }
        foreach (int itemList2 in list2)
        {
            if (list1.Contains(itemList2))
                continue;
            else
                myList.Add(itemList2);
        }
        myList.Sort();
        return(myList);
    }
}