using System;
using System.Collections;

namespace Array_List
{
  class Program
  {
    static void Main(string[] args)
    {
      // declaring an ArrayList with undefined amount of object
      ArrayList myArrayList = new ArrayList();
      // declaring an ArrayList with defined amount of object
      ArrayList myArrayList2 = new ArrayList(100);

      myArrayList.Add(24);
      myArrayList.Add("hello");
      myArrayList.Add(1.5);
      myArrayList.Add(15.5);
      myArrayList.Add(155);
      myArrayList.Add("bye");

      // delete element with specific value from the arraylist
      myArrayList.Remove(1.5);

      // delete element at specific position
      myArrayList.RemoveAt(0);

      Console.WriteLine(myArrayList.Count);

      double sum = 0;

      foreach (object obj in myArrayList)
      {
        if (obj is int)
        {
          sum += Convert.ToDouble(obj);
        }
        else if (obj is double)
        {
          sum += (double)obj;
        }
        else
        {
            Console.WriteLine(obj);
        }
      }
      Console.WriteLine(sum);
    }
  }
}
