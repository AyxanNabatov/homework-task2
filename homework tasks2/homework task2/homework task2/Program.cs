using System;

namespace homework_task2
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    //Dog dog = new Dog();
        //    //dog.Sound();

        //    //Bird bird = new Bird();
        //    //bird.Sound();
        //}
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Sound();
            dog.Eat();

            Bird bird = new Bird();
            bird.Sound();
            bird.Eat();

            Test test = new Test();
            test.Id = 6;

            Person person = new Person();
            person.Speak();

            //Animal animal = new Animal();
        }


    }
}
