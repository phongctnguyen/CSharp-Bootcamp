using System;

namespace Polymorphism_Example
{
    class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }  

        // has a relationship
        protected CarIDInfo carIDInfo = new CarIDInfo();

        public void SetCarIDInfo(int idNum, string owner)
        {
          carIDInfo.IDNum = idNum;
          carIDInfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
          Console.WriteLine($"The car has the ID of {carIDInfo.IDNum} and is owned by {carIDInfo.Owner}");
        }

        public Car()
        { 
          
        }

        public Car(int hp, string color)
        {
          this.HP = hp;
          this.Color = color;
        }   

        public void ShowDetails()
        {
          Console.WriteLine($"HP: {HP} color: {Color}");
        }

        public virtual void Repair()
        {
          Console.WriteLine("Car was repaired");
        }
    }
}
