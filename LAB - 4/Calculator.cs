using System;

namespace PRACTICALS_OOP
{
    public class Calculator
    {
        public static void add(int a  , int b)
        {
            Console.WriteLine("Void Method: ");
            Console.WriteLine("A + B = " + (a+b));

        }    
        public static int add(int a, int b , int c)
        {
            Console.WriteLine("Void Method: ");
            Console.WriteLine("A + B + C  = " + (a + b + c ));
            return a + b + c;
        }
        public static double add(double a, double b)
        {
            Console.WriteLine("Double Method: ");
            return a+b;
        }
    }
}
