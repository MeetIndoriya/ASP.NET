using System;

namespace PRACTICALS_OOP
{

    class Vehicle
    {
        public void VehicleCall()
        {
            Console.WriteLine("Vehicle Class Call");
        }
    }

    class Car : Vehicle
    {
        public void CarCall()
        {
            Console.WriteLine("Car Class Call");
        }
    }

    class InterfaceCar : Car
    {
        public void ElectricCall()
        {
            Console.WriteLine("Electric Class Call");
        }

    }
}
