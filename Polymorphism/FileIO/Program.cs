using System;
using System.IO;

namespace FileIO
{
  class Program
  {
    static void Main(string[] args)
    {
      // Method 1
      string[] lines2 = { "first line", "second line", "third line" };
      File.WriteAllLines(@"/mnt/d/Deep Learning/C# Bootcamp/Polymorphism/FileIO/Writefile.txt", lines2);

      // Method 2
    //   Console.WriteLine("Please give me the file a name");
    //   string fileName = Console.ReadLine();
    //   Console.WriteLine("Please enter the text for the file");
    //   string input = Console.ReadLine();
    //   File.WriteAllText($@"/mnt/d/Deep Learning/C# Bootcamp/Polymorphism/FileIO/{fileName}.txt", input);

      // Method 3
      using (StreamWriter file = new StreamWriter(@"/mnt/d/Deep Learning/C# Bootcamp/Polymorphism/FileIO/StreamWriter.txt"))
      {
        foreach (string line in lines2)
        {
          file.WriteLine(line);
        }
      }

      using (StreamWriter file = new StreamWriter(@"/mnt/d/Deep Learning/C# Bootcamp/Polymorphism/FileIO/StreamWriter.txt", true))
      {
          file.WriteLine("Additional line");
      }

        // Example 1 -reading Text
        string text = System.IO.File.ReadAllText(@"/mnt/d/Deep Learning/C# Bootcamp/Polymorphism/FileIO/TextFile.txt");

      Console.WriteLine($"Textfile contains following text {text}");

      string[] lines = System.IO.File.ReadAllLines(@"/mnt/d/Deep Learning/C# Bootcamp/Polymorphism/FileIO/TextFile.txt");

      Console.WriteLine($"Content of textfile.txt = ");
      foreach (string line in lines)
      {
        Console.WriteLine("\t" + line);
      }
    }
  }
}
