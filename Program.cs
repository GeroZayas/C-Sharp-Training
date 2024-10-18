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

