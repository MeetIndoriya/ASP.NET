using System;

namespace PRACTICALS_OOP
{
    public  class Employee
    {
        //display employee info.  1  Method -> name   2  Method -> name and age  3  Method -> name and age and salary 

        public static void dispEmployeeInfo(String name)
        {
            Console.WriteLine("Employee Name: " + name);
        }

        public static void dispEmployeeInfo(String name , int age)
        {
            Console.WriteLine("Employee Name: " + name + " Their Age Is: " + age);
        }

        public static void dispEmployeeInfo(String name , int age , double salary)
        {
            Console.WriteLine("Employee Name: " + name + " Their Age Is: " + age + " And Their Salary Is: " + salary);
        }
    }
}
