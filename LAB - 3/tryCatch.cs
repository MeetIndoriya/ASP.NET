using System;

namespace PRACTICALS_OOP
{
    public class tryCatch
    {
        int x;
        int y;

        public void setValue(int x, int y)
        {
            this.x = x;
            this.y = y;

            try
            {
                int result = x / y;
                Console.WriteLine("Result: " + result);
             }

            catch(Exception e) {
                Console.WriteLine("Enter Integer Number " + e);
            }

            finally
            {
                Console.WriteLine("Program Has Been Terminated ");
            }
        }

    }
}