using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Task2
{
    class Dog:Animals
    {
        public int pawCount;
        public override void Sound()
        {
            Console.WriteLine("Sound : woof-woof\n");

        }

        public override void Info()
        {
            Console.WriteLine($"Name : {Name}\nBreed : {Breed}\nPaw Count : {pawCount}");
        }

        public Dog(int pawCount, string Name, string Breed):base(Name,Breed)
        {
            this.pawCount = pawCount;
        }
    }
}
