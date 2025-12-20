using System;

namespace PRACTICALS_OOP
{
    public class Customer
    {
        public virtual void CalculateBill(double Amount) { 
        }

    }

    public class RegularCustomer : Customer
    {
        double Amount;
        public override void CalculateBill(double Amount)
        {
            this.Amount = Amount;
            double Discount = 0; 
            Discount = Discount + (Amount * 0.08);
            Console.WriteLine("\nRegularCustomer Discount:");
            Console.WriteLine("Orignal Price : " + Amount + " Discount: 8% Discounted Price:" + Discount + " Grand Price: " + (Amount - Discount));
        }
    }

    public class PremiumCustomer : Customer
    {
        double Amount;
        public override void CalculateBill(double Amount)
        {
            this.Amount = Amount;
            double Discount = 0;
            Discount = Discount + (Amount * 0.12);
            Console.WriteLine("\nPremiumCustomer Discount: \n\n");
            Console.WriteLine("Orignal Price : " + Amount + " Discount: 12% Discounted Price:" + Discount + " Grand Price: " + (Amount - Discount));
        }
    }
}
