using System;
using System.Collections.Generic;

namespace ArrayList_Lists_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> {1, 3, 4, 5};
            list.Add(9);
            list.Add(0);
            list.Add(34);
            list.Add(43);
            list.Sort();
            list.RemoveRange(2, 2);

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(list.Count);
            Console.WriteLine(list.Contains(4));

            int index = list.FindIndex(x => x == 34);
            Console.WriteLine(list[index]);

            list.RemoveAt(index);
            list.ForEach(i => Console.WriteLine(i));

        }
    }
}
