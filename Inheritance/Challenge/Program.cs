using System;

namespace Challenge
{
  class Program
  {
    static void Main(string[] args)
    {
      Employee michael = new Employee("Michael", "Boist", 40000);
      michael.Work();
      michael.Pause();

      Boss chuckNorris = new Boss("AudiV8", "Norris", "Chuck", 9999999);
      chuckNorris.Lead();

      Trainee daniel = new Trainee(32, 8, "Gaya", "Daniel", 222222);
      daniel.Learn();
      daniel.Work();
    }
  }
}
