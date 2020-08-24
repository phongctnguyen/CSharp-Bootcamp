using System;

namespace Polymorphism_Example
{
  class M3 : BMW
  {
    public M3(int hp, string color, string model) : base(hp, color, model)
    {
      this.Model = model;
    }
  }
}