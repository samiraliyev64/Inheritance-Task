using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Task1
{
    class Bus:Car
    {
        public int PassengerCount;

        public override void Info()
        {
            Console.WriteLine($"Brand : {Brand}\nModel : {Model}\nColor : {Color}\nMaxSpeed : {MaxSpeed}\nPassenger Count : {PassengerCount}");

        }

        public Bus(int PassengerCount, string Brand, string Model, string Color, int MaxSpeed):base(Brand,Model,Color,MaxSpeed)
        {
            this.PassengerCount = PassengerCount;
        }
    }
}
