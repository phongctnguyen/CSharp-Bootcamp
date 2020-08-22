using System;

namespace Challenge
{
  class Boss:Employee
  {
    public string CompanyCar { get; set; }

    public Boss(string companyCar, string name, string firstName, int salary):base(name, firstName, salary)
    {
      this.CompanyCar = companyCar;
    }

    public void Lead()
    {
      Console.WriteLine($"I'm boss! My name is {FirstName} {Name}");
    }
  }
}