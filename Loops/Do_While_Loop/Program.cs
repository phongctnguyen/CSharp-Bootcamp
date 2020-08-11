using System;

namespace Do_While_Loop
{
  class Program
  {
    static void Main(string[] args)
    {
    //   int counter = 0;
      int lengthOfText = 0;
      string wholeText = "";
    
      // do 
      // {
      //     Console.WriteLine(counter);
      //     counter++;
      // } while(counter < 5);

      do
      {
        Console.Write("Please enter the name of a friend: ");
        string nameOfAFriend = Console.ReadLine();
        int currentLength = nameOfAFriend.Length; ;
        lengthOfText += currentLength;
        wholeText += nameOfAFriend + " ";
      } while (lengthOfText < 20);

      Console.WriteLine(wholeText);

      Console.Read();
    }
  }
}
