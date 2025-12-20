using System;

namespace PRACTICALS_OOP
{

    class Shapes
    {
        public virtual void Area()
        {
            Console.WriteLine("Area Method Called");
        }
    }

    class Circle : Shapes
    {
        public override void Area()
        {
            Console.WriteLine("Enter The Radius Of Circle");
            string rad = Console.ReadLine();
            double rad2 = Convert.ToDouble(rad);
            double Area = 3.14 * rad2 * rad2;
            Console.WriteLine("Circle Area : - " + Area);
        }
    }
    class InterfaceShape : Shapes
    {
        public override void Area()
        {
            Console.WriteLine("Enter The Length Of Rectangle");
            string len = Console.ReadLine();
            double len2 = Convert.ToDouble(len);


            Console.WriteLine("Enter The Breath Of Rectangle");
            string Breath = Console.ReadLine();
            double Breath2 = Convert.ToDouble(Breath);

            double Area = len2 * Breath2;
            Console.WriteLine("Rectangle Area : - " + Area);
        }
    }
}
