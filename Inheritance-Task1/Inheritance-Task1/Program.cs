using System;

namespace Inheritance_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW","F10","Black",305);
            car.Info();
            Bus bus = new Bus(32, "Daewoo", "BH120F", "Grey", 100);
            bus.Info();
        }
    }
}
