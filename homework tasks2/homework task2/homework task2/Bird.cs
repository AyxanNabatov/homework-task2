using System;
using System.Collections.Generic;
using System.Text;

namespace homework_task2
{
    public class Bird : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Bird Sound");
        }

        public override void Eat()
        {
            Console.WriteLine("Bird Eating");

        }
    }
}
