using System;

namespace PRACTICALS_OOP

public class Student
{
	string Name;
	int RollNO;
	float Marks;

	public void display()
	{
		Console.WriteLine("Student Name: " + Name);
        Console.WriteLine("Student RollNo: " + RollNo);
        Console.WriteLine("Student Marks: " + Marks);
    }
}
