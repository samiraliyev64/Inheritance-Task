using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Task1
{
    class Car
    {
        public string Brand;
        public string Model;
        public string Color;
        public int MaxSpeed;
        

        public virtual void Info()
        {
            Console.WriteLine($"Brand : {Brand}\nModel : {Model}\nColor : {Color}\nMaxSpeed : {MaxSpeed}\n");
        }

        public Car()
        {
            Console.WriteLine("Car Created");
        }

        public Car(string Brand, string Model):this()
        {
            this.Brand = Brand;
            this.Model = Model;
        }

        public Car(string Brand, string Model, string Color, int MaxSpeed):this(Brand,Model)
        {
            this.Color = Color;
            this.MaxSpeed = MaxSpeed;
        }
    }
}
