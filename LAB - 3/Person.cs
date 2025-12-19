using System;

namespace PRACTICALS_OOP
{
    public class Person
    {
        string name;
        int roll;
        int age;
        string gender;

        public Person(string name, int age)
        {
            Console.WriteLine("Person Name: " + name + " Age: " + age);
        }
        public Person(string name, int age , string gender)
        {
            Console.WriteLine("Person Name: " + name + " Age: " + age + " Gender: " + gender);
        }
        public Person(string name, int age , string gender , int roll)
        {
            Console.WriteLine("Person Name: " + name + " Age: " + age + " Gender: " + gender + " Roll : "+ roll);
        }

    }
}
