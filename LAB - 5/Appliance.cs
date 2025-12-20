using System;

namespace PRACTICALS_OOP
{
    /// <summary>
    /// Create an abstract class Appliance with abstract method TurnOn(). 
    /// Derive Fan and Light classes that provide specific implementations of this method. 
    /// Demonstrate abstraction by calling methods using base class reference.
    /// </summary>
   
    
    public abstract class Appliance
    {
        public abstract void TurnOn();
    }

    class Fan : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine("Fan Turned On"); 
        }
    }

    class Light : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine("Light Turned On");
        }
    }
}
