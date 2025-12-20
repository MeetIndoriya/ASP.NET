using System;

namespace PRACTICALS_OOP
{ public interface Animals
    {
         void Eats();
    }
    
    public class InterfaceAnimal : Animals
    {
        public void Eats()
        {
            Console.WriteLine("Animal : Dog");
        }

        public void Bark()
        {
            Console.WriteLine("Dog Is Barking ");
        }
    }
}
