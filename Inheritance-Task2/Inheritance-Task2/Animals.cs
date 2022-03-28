using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Task2
{
    class Animals
    {
        public string Name;
        public string Breed;


       public virtual void Info()
        {
            Console.WriteLine($"Name : {Name}\nBreed : {Breed}");
        }
        public virtual void Sound()
        {
            Console.WriteLine("Animal sound");
        }

        public Animals(string Name, string Breed)
        {
            this.Name = Name;
            this.Breed = Breed;
        }
    }
}
