<div align = "center" >

# **ASP.NET PROGRAMS**

<hr>

## LAB - 2 PROGRAMS
</div>

<br><br>
###  LAB - 2<abbr> PROGRAM : 1 <abbr>
<hr><br>


Console.WriteLine("Enter The Number To Print Multiplication Table: ");

String multiplicationNumber = Console.ReadLine();

int multiplicationNumber2 = Convert.ToInt32(multiplicationNumber);              // Exception Chances

for (int i = 1; i <= 10; i++)

{

    Console.WriteLine(multiplicationNumber2 + " x " + i + " = " + multiplicationNumber2 \* i);

}

<br><br>
###  LAB - 2<abbr> PROGRAM : 2 <abbr>
<hr><br>

Console.WriteLine("Enter The String To Count Character , Digit , Special Character: ");

string sentance = Console.ReadLine();

int countDigit = 0;

int countCharacter = 0;

int countSpecialCharacter = 0;



for (int i = 0; i < sentance.Length; i++)

{

    if (char.IsDigit(sentance\[i]))

    {

        countDigit++;

    }



    else if (char.IsLetter(sentance\[i]))

    {

        countCharacter++;

    }

    else

    {

        countSpecialCharacter++;

    }

}



Console.WriteLine("Digits: " + countDigit);

Console.WriteLine("Character: " + countCharacter);

Console.WriteLine("Special Character: " + countSpecialCharacter);

<br><br>
###  LAB - 2<abbr> PROGRAM : 3 <abbr>
<hr><br>

            Console.WriteLine("Enter The Five Subject Marks Out Of 100: ");

            Console.WriteLine("Enter Maths Marks : ");

            string mathsMarks= Console.ReadLine();

            int mathsMarks2 = Convert.ToInt32(mathsMarks);



            Console.WriteLine("\\nEnter Physics Marks : ");

            string physicsMarks = Console.ReadLine();

            int physicsMarks2 = Convert.ToInt32(mathsMarks);



            Console.WriteLine("\\nEnter Science Marks : ");

            string scienceMarks = Console.ReadLine();

            int scienceMarks2 = Convert.ToInt32(mathsMarks);



            Console.WriteLine("\\nEnter Python Marks : ");

            string pythonMarks = Console.ReadLine();

            int pythonMarks2 = Convert.ToInt32(mathsMarks);



            Console.WriteLine("\\nEnter Java Marks : ");

            string javaMarks = Console.ReadLine();

            int javaMarks2 = Convert.ToInt32(mathsMarks);



            double sumMarks = mathsMarks2 + physicsMarks2 + scienceMarks2 + pythonMarks2 + javaMarks2;

            Console.WriteLine("Sum Of All Subject Marks: " + sumMarks);

            double avgMarks = sumMarks / 5;

            Console.WriteLine("Average All Subject Marks: " + avgMarks + "\\n");



            if (avgMarks >= 90 \&\& avgMarks <= 100)

            {

                Console.WriteLine("A++ Grade Archived");

            }

            else if (avgMarks >= 80 \&\& avgMarks <= 89)

            {

                Console.WriteLine("A+ Grade Archived");

            }

            else if (avgMarks >= 70 \&\& avgMarks <= 79)

            {

                Console.WriteLine("A Grade Archived");

            }

            else if (avgMarks >= 60 \&\& avgMarks <= 69)

            {

                Console.WriteLine("B Grade Archived");

            }

            else if (avgMarks >= 50 \&\& avgMarks <= 59)

            {

                Console.WriteLine("C Grade Archived");

            }

            else if (avgMarks >= 40 \&\& avgMarks <= 49)

            {

                Console.WriteLine("D Grade Archived");

            }

            else

            {

                Console.WriteLine("Fail");

            }






