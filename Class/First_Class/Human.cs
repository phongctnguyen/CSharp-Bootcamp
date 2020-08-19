using System;

namespace First_Class
{
  class Human
  {
    // member variable
    private string firstName; // default = null
    private string lastName;
    private string eyeColor;
    private int age; // default = 0

    // default constructor
    public Human()
    {

    }

    public Human(string firstName)
    {
      this.firstName = firstName;
    }

    public Human(string firstName, string lastName)
    {
      this.firstName = firstName;
      this.lastName = lastName;
    }

    public Human(string firstName, string lastName, string eyeColor)
    {
      this.firstName = firstName;
      this.lastName = lastName;
      this.eyeColor = eyeColor;
    }

    public Human(string firstName, string lastName, int age)
    {
      this.firstName = firstName;
      this.lastName = lastName;
      this.age = age;
    }

    // parameterized constructor
    public Human(string firstName, string lastName, string eyeColor, int age)
    {
      this.firstName = firstName;
      this.lastName = lastName;
      this.eyeColor = eyeColor;
      this.age = age;
    }

    // member

    public void IntroduceMyself()
    {
      if (age != 0 && lastName != null && eyeColor != null && firstName != null)
        Console.WriteLine("Hi, I'm {0} {1} and {2} years old. My eye color is {3}", firstName, lastName, age, eyeColor);
      else if (age != 0 && lastName != null && firstName != null)
      {
        Console.WriteLine("Hi, I'm {0} {1} and {2} years old.", firstName, lastName, age);
      }
      else if (lastName != null && firstName != null)
      {
        Console.WriteLine("Hi, I'm {0} {1}.", firstName, lastName);
      }
      else if (firstName != null)
      {
        Console.WriteLine("Hi, I'm {0} ", firstName);
      }
    }
  }
}
