<div align = "center">

# **ASP.NET PROGRAMS**
<hr>

##  					  LAB - 1 PROGRAMS
</div>

<br><br>
###  LAB - 1<abbr> PROGRAM : 1 <abbr>
<hr><br>

Console.WriteLine("Name: Meet");

Console.WriteLine("Address: Jamnagar");

Console.WriteLine("Contact: 745xxxxxx0");

Console.WriteLine("City: Jamnagar ");


<br><br>
###  LAB - 1<abbr> PROGRAM : 2 <abbr>
<hr><br>


Console.WriteLine("\\nEnter The First Number: ");

String Num1 = Console.ReadLine();

Console.WriteLine("Enter The Second Number");

String Num2 = Console.ReadLine();

int numFirst = Convert.ToInt32(Num1);           //Cast Into Integer

Double numSecond = Convert.ToDouble(Num2);       //Cast Into Double

Console.WriteLine("\\n" + Num1);

Console.WriteLine(Num2);

<br><br>
###  LAB - 1<abbr> PROGRAM : 3 <abbr>
<hr><br>

Console.WriteLine("\\nEnter Your Name: ");

String userName = Console.ReadLine();

Console.WriteLine("Enter Your Country: ");

String userCountry = Console.ReadLine();

Console.WriteLine("\\nUser's Name Is :- " + userName + " And Country Is :- " + userCountry);


<br><br>
###  LAB - 1<abbr> PROGRAM : 4 <abbr>
<hr><br>


Console.WriteLine("\\nEnter The Temperature in Celsius: - ");

String celsius = Console.ReadLine();

Double celsiusCon = Convert.ToDouble(celsius);

double fahrenheit = (((celsiusCon \* 9) / 5) + 32);

Console.WriteLine("\\n fahrenheit = " + fahrenheit);

<br><br>
###  LAB - 1<abbr> PROGRAM : 5 <abbr>
<hr><br>

Console.WriteLine("\\n Enter Your Net Salary: ");

String salary = Console.ReadLine();

Double newSalary = Convert.ToDouble(salary);

int hraSalary = 50000;

int daSalary = 40000;

int deduction = 25000;

Console.WriteLine("HRA 10%: " + (hraSalary \* 0.10));

Console.WriteLine("Da 15%: " + (daSalary \* 0.15));

Console.WriteLine("deduction 8%: " + (deduction \* 0.08));

Console.WriteLine("Employee Gross : " + ((hraSalary \* 0.10) + (daSalary \* 0.15) + (deduction \* 0.08)));

Console.WriteLine("Emplyee Net Salary After Gross:  " + (newSalary + (hraSalary \* 0.10) + (daSalary \* 0.15) + (deduction \* 0.08)));




