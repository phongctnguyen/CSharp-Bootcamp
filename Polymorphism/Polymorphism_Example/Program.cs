using System;
using System.Collections.Generic;

namespace Polymorphism_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Audi(200, "blue", "A4"),
                new BMW(250, "red", "M3"),
            };

            foreach (var car in cars)
            {
                car.Repair();
            }

            Car bmwZ3 = new BMW(200, "black", "Z3");
            Car audiA3 = new Audi(200, "green", "A3");
            bmwZ3.ShowDetails();
            audiA3.ShowDetails();

            bmwZ3.SetCarIDInfo(1234, "Phong");
            audiA3.SetCarIDInfo(12345, "Frank");
            bmwZ3.GetCarIDInfo();
            audiA3.GetCarIDInfo();

            BMW bmwM5 = new BMW(333, "white", "M5");
            bmwM5.ShowDetails();
            Audi audiG2 = new Audi(200, "pink", "G2");
            audiG2.ShowDetails();

            Car carB = (Car)bmwM5;
            carB.ShowDetails();

            M3 myM3 = new M3(200, "red", "Super Turbo");
            myM3.Repair();
        }
    }
}
