using System;

namespace PRACTICALS_OOP
{
    public  class Rectangle
    {
        public float length;
        public float breadth;

        public Rectangle(float length , float breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }

        public float recDisplay()
        {
            return length * breadth;
        }
    }
}
