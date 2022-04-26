using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        var myList = new List<int>();

        for (int i = 0; i < listLength; i++)
        {
            try
            {
                myList.Add(list1[i] / list2[i]);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                System.Console.WriteLine("Out of range");
            }
            catch (System.DivideByZeroException)
            {
                myList.Add(0);
                System.Console.WriteLine("Cannot divide by zero");
            }

        }
        return myList;
    }
}
