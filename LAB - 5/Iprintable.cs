using System;
using System.Security.Cryptography.X509Certificates;

namespace PRACTICALS_OOP
{

    /// <summary>
    /// Create an interface IPrintable with a method PrintDetails(). 
    /// Implement this interface in two classes: Book and Magazine. Each should display different information.
    /// </summary>
  
    public interface iprintable
    {
         void Print();
    }

    public class Iprintable : iprintable
    { 
        public void Print()
        {
            string BookName = "Atomic Habit";
            Console.WriteLine("Book Name: " + BookName);
        }
    }

    class Magazines : iprintable
    {
        public void Print()
        {
            string MagazineName = "Xyz";
            Console.WriteLine("Magazine Name: " + MagazineName);
        }
    }


}
