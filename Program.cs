/*Exercises from https://www.w3resource.com/csharp-exercises/basic/index.php*/

using System;
using System.Configuration.Assemblies;

/*
Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user.
Test Data:
Input the first number to multiply: 2
Input the second number to multiply: 3
Input the third number to multiply: 6
Expected Output:
2 x 3 x 6 = 36
*/

/*
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Write your first number: ");
        int first = Convert.ToInt32(Console.ReadLine());

        Console.Write("Write your first number: ");
        int second = Convert.ToInt32(Console.ReadLine());

        Console.Write("Write your first number: ");
        int third = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The result of the 3 numbers multiplied is:" + "\n");
        Console.WriteLine(first * second * third);
    }
}

*/


/*
7. Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing two numbers entered by the user.
Test Data:
Input the first number: 25
Input the second number: 4
Expected Output:
25 + 4 = 29
25 - 4 = 21
25 x 4 = 100
25 / 4 = 6
25 mod 4 = 1
*/

/*
class Program
{
    static void Main(string[] args)
    {

        Console.Write("Write your first number: ");
        int first = Convert.ToInt32(Console.ReadLine());

        Console.Write("Write your first number: ");
        int second = Convert.ToInt32(Console.ReadLine());

        int sum = first + second;
        int substraction = first - second;
        int multiplication = first * second;
        int division = first / second;
        int mod = first % second;

        Console.WriteLine(@$"
        The sum             {sum}

        The substraction    {substraction}

        The multiplication  {multiplication}

        The division        {division}

        the mod             {mod}
        
        ");

    }
}

*/

/*
Write a C# Sharp program that prints the multiplication table of a number as input. 

Test Data:
Enter the number: 5
Expected Output:
5 * 0 = 0
5 * 1 = 5
5 * 2 = 10
5 * 3 = 15
....
5 * 10 = 50

*/

/*
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insert your number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"This is the multiplication table of {num}");

        for (int i = 1; i < 11; i++)
        {
            Console.WriteLine($"{num} * {i} ==>\t\t{num * i}");
        }

    }
}

*/

/*
9. Write a C# Sharp program that takes four numbers as input to calculate and print the average.
Test Data:
Enter the First number: 10
Enter the Second number: 15
Enter the third number: 20
Enter the four number: 30

Expected Output:
The average of 10 , 15 , 20 , 30 is: 18
*/


/*
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This program takes 4 numbers and gives their average");

        Console.WriteLine("Insert first nummber: ");
        int first = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Insert second nummber: ");
        int second = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Insert third nummber: ");
        int third = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Insert fourth nummber: ");
        int fourth = Convert.ToInt32(Console.ReadLine());

        int avg = (first + second + third + fourth) / 4;

        Console.WriteLine($"The average of these numbers is: {avg}");
    }
}

*/

/*
10. Write a C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z.
Test Data:
Enter first number - 5
Enter second number - 6
Enter third number - 7

Expected Output:
Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72
*/

/*
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter 3 numbers to perform calculation: ");

        Console.Write("Enter first number: ");
        int first = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int second = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter third number: ");
        int third = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"({first} + {second}) * {third} is:");

        Console.WriteLine(calculation1(first, second, third));

        Console.WriteLine($"({first} * {second}) + ({second} * {third}) is:");

        Console.WriteLine(calculation2(first, second, third));


    }

    private static int calculation1(int a, int b, int c)
    {
        return (a + b) * c;
    }

    private static int calculation2(int a, int b, int c)
    {
        return (a * b) + (b * c);
    }
}

*/


/*
12. Write a C# program that takes a number as input and displays it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it twice: Use the console. Write and use {0}.
Test Data:
Enter a digit: 25
Expected Output:
25 25 25 25
25252525
25 25 25 25
25252525
*/
/*
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number, please:");
        int num = Convert.ToInt32(Console.ReadLine());

        int i = 0;

        while (i < 2)
        {
            printWithSpace(num, 4);

            Console.WriteLine();

            printWithOutSpace(num, 4);

            Console.WriteLine();

            i++;
        }

    }

    static void printWithSpace(int n, int repetitions)
    {
        for (int i = 0; i < repetitions; i++)
        {
            Console.Write($"{n} ");
        }
    }

    static void printWithOutSpace(int n, int repetitions)
    {
        for (int i = 0; i < repetitions; i++)
        {
            Console.Write($"{n}");
        }
    }
}
*/

/*

14. Write a C# program to convert Celsius degrees to Kelvin and Fahrenheit.
Test Data:
Enter the amount of celsius: 30
Expected Output:
Kelvin = 303
Fahrenheit = 86
*/

/*
namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double kelvin = toKelvin(celsius);
            double fahrenheit = toFahrenheit(celsius);

            Console.WriteLine($"{celsius} in Kelvin is {kelvin}");
            Console.WriteLine($"{celsius} in Fahrenheit is {fahrenheit}");
        }

        static double toKelvin(double num)
        {
            return num + 273.15;
        }

        static double toFahrenheit(double num)
        {
            return (1.8 * num) + 32;
        }
    }
}
*/