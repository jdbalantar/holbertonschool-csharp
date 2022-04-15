using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        var Lista1 = Lista1.FindAll(elem => !Lista2.Contains(elem));
        var Lista2 = Lista2.FindAll(elem => !Lista1.Contains(elem));
        Lista1.AddRange(Lista2);
        Lista1.Sort();
        return Lista1;
    }
}