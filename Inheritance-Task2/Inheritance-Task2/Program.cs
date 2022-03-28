using System;

namespace Inheritance_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals dog = new Dog(4, "Dog", "German Shepherd");
            dog.Info();
            dog.Sound();


            Animals snake = new Snake(120, "Snake", "Black Mamba");
            snake.Info();
            snake.Sound();
        }
    }
}
