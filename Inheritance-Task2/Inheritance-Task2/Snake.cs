using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Task2
{
    class Snake:Animals
    {
        public int venomToxicity;

        public override void Sound()
        {
            Console.WriteLine("Sound : Tssssss"); ;
        }

        public override void Info()
        {
            Console.WriteLine($"Name : {Name}\nBreed : {Breed}\nVenom Toxicity : {venomToxicity} mg");
        }

        public Snake(int venomToxicity, string Name, string Breed):base(Name,Breed)
        {
            this.venomToxicity = venomToxicity;
        }
    }
}
