using System;

namespace PRACTICALS_OOP
{
    /// <summary>
    ///Develop an online payment system using abstraction and inheritance.
    ///Create an abstract class Payment with abstract method MakePayment(). 
    ///Derive classes CreditCardPayment and UPIPayment that implement this method differently. 
    ///Use exception handling if the amount entered is less than ₹100.
    /// </summary>
    
    public abstract class Payment
    {
        public abstract void MakePayment();
    }

    class Credit : Payment
    {
        private float balance = 10000;
        public override void MakePayment()
        {
            Console.WriteLine("Current Balance: " + balance);
            Console.WriteLine("\nEnter The Amount To Credit: ");
            String Amount = Console.ReadLine();
            float Amount2 = Convert.ToSingle(Amount);

            try
            {
                balance = balance - Amount2;
                if (balance > 100f)
                {
                    Console.WriteLine("Balance: " + balance);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Insufficient Balance: " + e);
            }
        }
    }
    class UPI : Payment
    {
        private float balance = 10000;
        public override void MakePayment()
        {
            Console.WriteLine("\n\nCurrent Balance: " + balance);
            Console.WriteLine("Enter The Amount To Pay With UPI: ");
            String Amount = Console.ReadLine();
            float Amount2 = Convert.ToSingle(Amount);

            try
            {
                balance = balance - Amount2;
                if (balance > 100f)
                {
                    Console.WriteLine("Balance: " + balance);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Insufficient Balance: " + e);
            }
        }
    }
}

