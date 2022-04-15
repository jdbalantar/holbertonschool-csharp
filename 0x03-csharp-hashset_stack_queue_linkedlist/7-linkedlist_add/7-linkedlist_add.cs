using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
    {
		var firstNode = new LinkedListNode<int>(n);
        myLList.AddFirst(firstNode);
        return firstNode;
    }
}