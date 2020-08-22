using System;

namespace Challenge
{
  class Employee
  {
    public string Name { get; set; }
    public string FirstName { get; set; }
    public int Salary { get; set; }

    public Employee(string name, string firstName, int salary)
    {
      this.Name = name;
      this.FirstName = firstName;
      this.Salary = salary;
    }

    public Employee()
    {
      Name = "Phong";
      FirstName = "Nguyen";
      Salary = 50000;
    }

    public void Work()
    {
      Console.WriteLine("I'm working");
    }

    public void Pause()
    {
      Console.WriteLine("I'm having a break");
    }
  }
}
