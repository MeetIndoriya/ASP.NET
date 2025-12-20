using System;

namespace PRACTICALS_OOP
{
    /// <summary>
    /// Define two interfaces IMovable and ISound. 
    /// Create a class Robot that implements both interfaces, providing methods for Move() and MakeSound(). 
    /// Demonstrate multiple interface implementation in C#.
    /// </summary>
    interface Imoveable
    {
        void Move();
    }

    interface Isound : Imoveable
    {
        void MakeSound();
    }

    public class Robot : Isound
    {
        public void Move()
        {
            Console.WriteLine("Robot Is Noe Moving");
        }

        public void MakeSound()
        {

            Console.WriteLine("Robot Make Sound By Communication");
        }
    }
}
