using System;
using System.Collections.Generic;
using System.Text;

namespace homework_task2
{
    public class Person : Test, ISpeak, IEating
    {
        public void Eating(DateTime time)
        {
            Console.WriteLine("Perason Eating" + DateTime.Now);
        }

        //public void Speak()
        //{
        //    Console.WriteLine("Person speaking");
        //}
        public void Speak()
        {
            Console.WriteLine("Person speaking");
        }
    }

    public interface ISpeak
    {
        void Speak();
    }

    public interface IEating
    {
        void Eating(DateTime time);
    }
}
