using System;
using System.Collections.Generic;

class LList
{
	public static int GetNode(LinkedList<int> myLList, int n)
	{
		int ID = 0;
		foreach (int item in myLList)
		{
			if (ID == n)
				return (item);
			ID++;
		}
		return (0);
	}
}