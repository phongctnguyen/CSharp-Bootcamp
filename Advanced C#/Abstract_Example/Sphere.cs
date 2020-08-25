using System;

namespace Abstract_Example
{
  class Sphere : Shape
  {

    public double Radius { get; set; }

    public Sphere(double radius)
    {
      this.Name = "Sphere";
      this.Radius = radius;
    }
    public override double Volume()
    {
      return Math.PI * (Math.Pow(Radius, 3)) * 4 / 3; 
    }
    public override void GetInfo()
    {
      base.GetInfo();
      Console.WriteLine($"\nThe Sphere has a radius of {Radius}");
    }
  }
}
