// See https://aka.ms/new-console-template for more information
using System;
using System.Net.NetworkInformation;

Console.WriteLine(" \n Choose an operation : ");

Console.WriteLine("\n1.Sum");
Console.WriteLine("2.Subtraction");
Console.WriteLine("3.Multiplication");
Console.WriteLine("4.Divison");
Console.WriteLine("5.Exponentiation");
Console.WriteLine("6.Even / Odd");
Console.WriteLine("7.Prime");
Console.WriteLine("8.Square root");
Console.WriteLine("9.Mirrored");
Console.WriteLine("10.Palindrome");
Console.WriteLine("11.Superpalidrome ");
Console.WriteLine("12.Modulus of x");
Console.WriteLine("13.Display palindrome and superpalindrome numbers between 1 and 10000");
Console.WriteLine("14.Display superpalindrome numbers between 1 and 10000");



string opertaion = Console.ReadLine();

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


double operationNumber = 0;

while (!double.TryParse(opertaion, out operationNumber) || (operationNumber != 1 && operationNumber != 2 && operationNumber != 3 && operationNumber != 4 && operationNumber != 5 && operationNumber != 6 && operationNumber != 7 && operationNumber != 8 && operationNumber != 9 && operationNumber != 10 && operationNumber != 11 && operationNumber != 12 && operationNumber != 13 && operationNumber !=14))
{
    Console.WriteLine(" \n Choose a valid operation ");
    opertaion = Console.ReadLine();
}


switch (operationNumber)
{
    case 1:
        double sumResult = number1 + number2;

        Console.WriteLine("Sum Result =" + sumResult);
        break;
    case 2:
        double subResult = number1 - number2;

        Console.WriteLine("Substraction Result =" + subResult);
        break;
    case 3:

        double multiplicantionResult = number1 * number2;

        Console.WriteLine("Multiplicantion Result =" + multiplicantionResult);
        break;
    case 4:
        if (number2 == 0)
        {
            Console.WriteLine("Number2 must not be 0");
        }
        else
        {

            double divResult = number1 / number2;

            Console.WriteLine("Division Result =" + divResult);
        }
        break;

    case 5:

        if (number2 == 0)
        {
            Console.WriteLine("Exponentiation Result = 1");
        }
        else if (number2 == 1)
        {
            Console.WriteLine("Exponentiation Result =" + number1);
        }
        else
        {
            double expoResult = 1;
            for (int i = 0; i < number2; i++)
            {
                expoResult = expoResult * number1;
            }
            Console.WriteLine(" Exponentiation Result =" + expoResult);
        }
        break;


    case 6:


        if (number1 % 2 == 0)
        {
            Console.WriteLine(" Number1 is Even");
        }
        else
        {
            Console.WriteLine(" Number1 is Odd");
        }

        if (number2 % 2 == 0)
        {
            Console.WriteLine(" Number2 is Even");
        }
        else
        {
            Console.WriteLine(" Number2 is Odd");
        }
        break;

    case 7:

        bool isPrime = true;
        if (number1 == 0 || number1 == 1)
        {
            isPrime = false;
        }
        else if (number1 == 2)
        {
            isPrime = true;
        }
        else if (number1 % 2 == 0)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 3; i < Math.Sqrt(number1); i = i + 2)
            {
                if (number1 % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
        {
            Console.WriteLine("Number1 is prime");
        }
        else
        {
            Console.WriteLine("Number1 is not prime");
        }

        if (number2 == 0 || number2 == 1)
        {
            isPrime = false;
        }
        else if (number2 == 2)
        {
            isPrime = true;
        }
        else if (number2 % 2 == 0)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 3; i < Math.Sqrt(number2); i = i + 2)
            {
                if (number2 % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
        {
            Console.WriteLine("Number2 number is prime");
        }
        else
        {
            Console.WriteLine("Number2 is not prime");
        }
        break;

    case 8:
        if (number1 == 0 || number1 == 1)
        {
            Console.WriteLine("Square root of number1 is " + number1);
        }
        else
        {
            Console.WriteLine("Square root of number1 is " + Math.Sqrt(number1));
        }

        if (number2 == 0 || number2 == 1)
        {
            Console.WriteLine("Square root of number2 is " + number2);
        }
        else
        {
            Console.WriteLine("Square root of number2 is " + Math.Sqrt(number2));
        }

        break;

    case 9:
        int mirrored1 = 0;
        int mirrored2 = 0;
        int numb1 = Convert.ToInt32(number1);
        while (numb1 != 0)
        {
            mirrored1 = (mirrored1 * 10) + (numb1 % 10);
            numb1 = numb1 / 10;
        }
        Console.WriteLine("Mirrored number1 is " + mirrored1);

        int numb2 = Convert.ToInt32(number2);
        while (numb2 != 0)
        {
            mirrored2 = (mirrored2 * 10) + (numb2 % 10);
            numb2 = numb2 / 10;
        }
        Console.WriteLine("Mirrored number2 is " + mirrored2);

        break;

    case 10:

        int mirrored = 0;
        numb1 = Convert.ToInt32(number1);
        while (numb1 != 0)
        {
            mirrored = (mirrored * 10) + (numb1 % 10);
            numb1 = numb1 / 10;
        }
        Console.WriteLine("Mirrored number is " + mirrored);

        if (mirrored == number1)
        {
            Console.WriteLine("The number is palindrom");
        }
        else
        {
            Console.WriteLine("The number is not palindrom ");
        }

        if (mirrored == number2)
        {
            Console.WriteLine("The number is palindrom");
        }
        else
        {
            Console.WriteLine("The number is not palindrom ");
        }
        break;

    case 11:
        int mir = 0;
        numb1 = Convert.ToInt32(number1);
        while (numb1 != 0)
        {
            mir = (mir * 10) + (numb1 % 10);
            numb1 = numb1 / 10;
        }

        double numbPow = Math.Pow(number1, 2);
        int mirPal = 0;
        int numbPow1 = Convert.ToInt32(numbPow);

        while (numbPow1 != 0)
        {
            mirPal = (mirPal * 10) + (numbPow1 % 10);
            numbPow1 = numbPow1 / 10;
        }

        if ((mir == number1) && (mirPal == numbPow))
        {
            Console.WriteLine("The number is super palindrom");
        }
        else
        {
            Console.WriteLine("The number is not super palindrom ");
        }

        break;

    case 12:

        double valAbs = 0;
        if (number1 >= 0)
        {
            valAbs = number1;
        }
        else
        {
            valAbs = -number1;
        }
        Console.WriteLine("Modulus of number1 " + valAbs);

        double valAbs2 = 0;
        if (number2 >= 0)
        {
            valAbs2 = number2;
        }
        else
        {
            valAbs2 = -number2;
        }
        Console.WriteLine("Modulus of number2 " + valAbs2);
        break;


    case 13:

        for (int k = 1; k <= 10000; k++)
        {

            string data = k.ToString();

            bool isPalindrome = true;

            for (int i = 0; i < data.Length / 2; i++)
            {

                if (data[i] != data[(data.Length - 1) - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine("Palindrome :" + k);
            }
        }
        break;

        case 14:

         for (int k = 1; k <= 1000; k++)
        {
            double kPow = Math.Pow(k, 2);

            string data = kPow.ToString();

            bool isSuperPalindrome = true;

            for (int i = 0; i < data.Length / 2; i++)
            {

                if (data[i] != data[(data.Length - 1) - i])
                {
                    isSuperPalindrome = false;
                    break;
                }
            }

            if (isSuperPalindrome)
            {
                Console.WriteLine("Super Palindrome :" + kPow);
            }
        }

        break;



}

