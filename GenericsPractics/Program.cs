using System;
using System.Collections.Generic;

namespace GenericsPractics
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();

            list.AddFirst(2);
            list.AddFirst(3);

            var fast = list.First;
            list.AddAfter(fast, 33);
            list.AddBefore(list.AddAfter(fast, 100), 200);

            var node = list.First;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }
}
