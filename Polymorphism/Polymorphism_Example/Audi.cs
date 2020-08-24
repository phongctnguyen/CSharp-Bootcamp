using System;

namespace Polymorphism_Example
{
  class Audi : Car
  {
    private string brand = "Audi";

    public string Model { get; set; }

    public Audi(int hp, string color, string model) : base(hp, color)
    {
      this.Model = model;
    }

    public new void ShowDetails()
    {
      Console.WriteLine($"Brand {brand} HP: {HP} color: {Color}");
    }

    public override void Repair()
    {
      Console.WriteLine($"The Audi {Model} was repaired");
    }
  }
}
