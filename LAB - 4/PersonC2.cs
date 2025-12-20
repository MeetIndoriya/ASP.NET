using System;

namespace PRACTICALS_OOP
{
    public class PersonC2
    {
        public string person_name; // Universal
        protected int person_age;   // Access With Child 
        private double person_salary;   // Access With Same Class Method
        internal string person_designation;  // Access Anywhere In Project ( Same As Default )

        public void setSalary(double salary)
        {
            this.person_salary = salary;
        }

        public void displayInfo()
        {
            Console.WriteLine("Person Name : " + person_name + "\nAge : "+ person_age + "\nWith Salary : " + person_salary + "\nTheir Desgination Is : " + person_designation);
        }

    }

    class PersonC3 : PersonC2
    {
        public void setAge(int age)
        {
            this.person_age = age;
        }

    }
}
