using System;

namespace PRACTICALS_OOP
{
    public class Animal
    {
        public virtual void sound()
        {
            Console.WriteLine("Animal Can Sound");
        }
    }

    class Dog : Animal
    {
        public override void sound()
        {
            Console.WriteLine("Barking");
        }
    }

    class Cat : Animal
    {
        public override void sound()
        {
            Console.WriteLine("Meow");
        }
    }

}
