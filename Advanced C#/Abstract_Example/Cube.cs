using System;

namespace Abstract_Example
{
  class Cube : Shape
  {

    public double Length { get; set; }

    public Cube(double length)
    {
      this.Name = "Cube";
      this.Length = length;
    }
    public override double Volume()
    {
      return Math.Pow(Length, 3); 
    }
    public override void GetInfo()
    {
      base.GetInfo();
      Console.WriteLine($"\nThe Cube has a length of {Length}");
    }
  }
}
