using System;
using System.Collections.Generic;

class LList
{
	public static LinkedList<int> CreatePrint(int size)
	{
        int i;
		var linkedList = new LinkedList<int>();
		if (size <= 0)
			return linkedList;
		for (i = 0; i < size; i++)
		{
			Console.WriteLine(i);
			linkedList.AddLast(i);
		}
		return linkedList;
	}
}