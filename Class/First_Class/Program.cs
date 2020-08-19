using System;

namespace First_Class
{
  class Program
  {
    static void Main(string[] args)
    {
      // create an object (instance) of Human class
      Human phong = new Human("Phong", "Nguyen", "black", 26);
      phong.IntroduceMyself();

      Human yuki = new Human("Yukino", "Yukinoshita", "blue", 18);
      yuki.IntroduceMyself();

      Human basicHuman = new Human();
      basicHuman.IntroduceMyself();

      Human natalie = new Human("Natalie");
      natalie.IntroduceMyself();

      Human michael = new Human("Michael", "Miller");
      michael.IntroduceMyself();

      Human frank = new Human("Frank", "Walter", 25);
      frank.IntroduceMyself();

      // access variable
      //   phong.firstName = "Phong";
      //   phong.lastName = "Nguyen";

      Console.ReadKey();
    }
  }
}
