// See https://aka.ms/new-console-template for more information
using System;
using System.Net.NetworkInformation;

double number1 = 0;

Console.WriteLine("Enter Number1 :");


string theNumberAsAString = Console.ReadLine();


while (!double.TryParse(theNumberAsAString, out number1))
{
    Console.WriteLine(" \n This is not a number. Enter a number : ");
    theNumberAsAString = Console.ReadLine();
}

Console.WriteLine(" \n The number is : " + number1);



double number2 = 0;

Console.WriteLine(" \n Enter Number2 :");

string theNumberAsAString2 = Console.ReadLine();

while (!double.TryParse(theNumberAsAString2, out number2))
{
    Console.WriteLine(" \n This is not a number. Entere a number : ");
    theNumberAsAString2 = Console.ReadLine();
}

Console.WriteLine(" \nThe number is " + number2);

Console.WriteLine(" \n Choose an operation : ");

Console.WriteLine("\n1.Sum");
Console.WriteLine("2.Subtraction");
Console.WriteLine("3.Multiplication");
Console.WriteLine("4.Divison");



string opertaion = Console.ReadLine();

double operationNumber = 0;

while (!double.TryParse(opertaion, out operationNumber) || (operationNumber != 1 && operationNumber != 2 && operationNumber != 3 && operationNumber != 4))
{
    Console.WriteLine(" \n Choose a valid operation ");
    opertaion = Console.ReadLine();
}


switch (operationNumber)
{
    case 1:
        double sumresult = number1 + number2;

        Console.WriteLine("Sum Result :" + sumresult);
        break;
    case 2:
        double subresult = number1 - number2;

        Console.WriteLine("Substraction Result :" + subresult);
        break;
    case 3:

        double multiplicantionResult = number1 * number2;

        Console.WriteLine("Multiplicantion Result :" + multiplicantionResult);
        break;
    case 4:
        if (number2 == 0)
        {
            Console.WriteLine("Number2 must not be 0");
        }
        else
        {

            double divresult = number1 / number2;

            Console.WriteLine("Division Result :" + divresult);
        }
        break;


}
