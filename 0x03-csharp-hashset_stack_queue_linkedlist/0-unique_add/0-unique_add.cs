using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        var hash = new HashSet<int>(myList);
        int n = 0;
        foreach (var i in hash){
            n += i;
        }
    return n;
    }
}