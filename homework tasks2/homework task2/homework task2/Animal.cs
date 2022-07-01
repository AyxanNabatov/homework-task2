using System;
using System.Collections.Generic;
using System.Text;

namespace homework_task2
{
    
    //public abstract class Animal
    //{
    //    public string Name { get; set; }

    //    public virtual void Sound()
    //    {
    //        Console.WriteLine("Sound");
    //
    //}
    public abstract class Animal
    {
        public string Name { get; set; }

        //public Animal()
        //{

        //}


        public abstract void Eat();


        public virtual void Sound()
        {
            Console.WriteLine("Sound");
        }

    }
}
