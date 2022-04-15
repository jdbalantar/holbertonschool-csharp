using System;
using System.Collections.Generic;

class LList
{
	public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
	{
		var temp = myLList.First;
		while (temp != null)
		{
			if (n < temp.Value)
				return myLList.AddBefore(temp, n);
			temp = temp.Next;
		}
		return myLList.AddLast(n);
	}
}