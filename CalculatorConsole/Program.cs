// See https://aka.ms/new-console-template for more information
using System;

double number1 = 0;

Console.WriteLine("Enter Number1 :");
number1 = Convert.ToDouble(Console.ReadLine());

double number2 = 0;

Console.WriteLine("Enter Number2 :");
number2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("1.Sum");
Console.WriteLine("2.Subtraction");
Console.WriteLine("3.Multiplication");
Console.WriteLine("4.Divison");


double Result = Convert.ToDouble(Console.ReadLine());

switch (Result)
{
    case 1:
        double SumResult = number1 + number2;

        Console.WriteLine("Sum Result :" + SumResult);
        break;
    case 2:
        double SubResult = number1 - number2;

        Console.WriteLine("Substraction Result :" + SubResult);
        break;
    case 3:

        double MultiplicantionResult = number1 * number2;

        Console.WriteLine("Multiplicantion Result :" + MultiplicantionResult);
        break;
    case 4:
        if (number2 == 0)
        {
            Console.WriteLine("Number2 must not be 0");
        }
        else
        {

            double DivResult = number1 / number2;

            Console.WriteLine("Division Result :" + DivResult);
        }
        break;

}





















