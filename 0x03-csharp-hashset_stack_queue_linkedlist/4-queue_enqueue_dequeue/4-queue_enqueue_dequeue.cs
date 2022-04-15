using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        int count = aQueue.Count;
        bool inn = aQueue.Contains(search);
        Console.WriteLine($"Number of items: {count}");
        if (count == 0)
            Console.WriteLine("Queue is empty");
        else
            Console.WriteLine($"First item: {aQueue.Peek()}");
        Console.WriteLine($"Queue contains \"{search}\": {inn}");
        if (inn == true)
        {
            while (aQueue.Dequeue() != search)
                continue;
        }
        aQueue.Enqueue(newItem);
        return (aQueue);


    }
}