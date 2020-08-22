using System;

namespace Challenge
{
  class Trainee : Employee
  {
    public int WorkingHours { get; set; }
    public int SchoolHours { get; set; }

    public Trainee(int workingHours, int schoolHours, string name, string firstName, int salary) : base(name, firstName, salary)
    {
      this.WorkingHours = workingHours;
      this.SchoolHours = schoolHours;
    }

    public void Learn()
    {
      Console.WriteLine($"I'm learning for {SchoolHours} hours");
    }

    public new void Work()
    {
      Console.WriteLine($"I work for {WorkingHours} hours");
    }
  }
}