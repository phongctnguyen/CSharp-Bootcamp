using System;

namespace Date_Time
{
  class Program
  {
    static void Main(string[] args)
    {
      DateTime dateTime = new DateTime(2020, 5, 21);
      Console.WriteLine($"The day is {dateTime}");

      // Write today on screen
      Console.WriteLine(DateTime.Today);
      Console.WriteLine(DateTime.Now);

      DateTime tomorrow = GetTomorrow();
      Console.WriteLine(tomorrow);

      Console.WriteLine(GetFirstDayOfYear(1994));

      int days = DateTime.DaysInMonth(1994, 10);
      Console.WriteLine($"{days}");

      Console.WriteLine($"{DateTime.Now.Minute}");

      Console.WriteLine("Write a date in this format: yyyy-mm-dd");
      string input = Console.ReadLine();
      if(DateTime.TryParse(input, out dateTime))
      {
          Console.WriteLine(dateTime);
          TimeSpan daysPassed = DateTime.Now.Subtract(dateTime);
          Console.WriteLine($"Days passed since: {daysPassed.Days}");
      }
      else
      {
          Console.WriteLine("Wrong input");
      }
    }
    static DateTime GetTomorrow()
    {
      return DateTime.Today.AddDays(1);
    }

    static DateTime GetFirstDayOfYear(int year)
    {
      return new DateTime(year,1, 1);
    }
  }
}
