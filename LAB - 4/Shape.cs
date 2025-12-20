using System;

namespace PRACTICALS_OOP
{
    public class Shape
    {
        public virtual void CalculateArea()
        {
            Console.WriteLine(" Mrthod For Calculate Area ");
        }
    }

    public class Sqaure : Shape
    {
        public override void CalculateArea()
        {
            base.CalculateArea();
            Console.WriteLine("--------  Calculate Sqaure Area --------  \n\n");
            Console.WriteLine("Enter The Value Of Length: ");
            string length = Console.ReadLine();
            int length2 = Convert.ToInt32(length);

            Console.WriteLine("Enter The Value Of Width: ");
            string width = Console.ReadLine();
            int width2 = Convert.ToInt32(width);

            Console.WriteLine("Area Of Sqaure: " + (length2 * width2));
        }
    }

    public class Cube : Shape
    {
        public override void CalculateArea()
        {
            Console.WriteLine("--------  Cube Sqaure Area --------  \n\n");
            Console.WriteLine("Enter The Value Of Length: ");
            string length = Console.ReadLine();
            int length2 = Convert.ToInt32(length);

            Console.WriteLine("Enter The Value Of Width: ");
            string width = Console.ReadLine();
            int width2 = Convert.ToInt32(width);


            Console.WriteLine("Enter The Value Of Height: ");
            string height = Console.ReadLine();
            int height2 = Convert.ToInt32(height);
            Console.WriteLine("Area Of Sqaure: " + (length2 * width2 * height2));
        }
    }
}
