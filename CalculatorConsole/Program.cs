
using System;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace CalculatorConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                ShowOperationsMenu();
                DoOperation();
                Console.WriteLine("Would you like to do another operation? y/n");
            } while (Console.ReadLine().ToLower() == "y");
        }

        private static void DoOperation()
        {
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "1":
                    {
                        CalculateTwoDoubleNumberSum();
                        break;
                    }

                case "2":
                    {
                        CalculateTwoDoubleNumberSubstraction();
                        break;
                    }
                case "3":
                    {
                        CalculateTwoDoubleNumberMultiplication();
                        break;
                    }
                case "4":
                    {
                        CalculateTwoDoubleNumberDivision();
                        break;
                    }
                case "5":
                    {
                        CalculateDoubleNumberExponentiation();
                        break;
                    }

                case "6":
                    {
                        CalculateNumberParity();
                        break;
                    }
                case "7":
                    {
                        ShowIfNumberIsPrime();

                        break;
                    }
                case "8":
                    {
                        CalculateSquareRootOfDoubleNumber();

                        break;
                    }
                case "9":
                    {
                        CalculateMirroredOfDoubleNumber();
                        break;
                    }
                case "10":
                    {
                        ShowIfNumberIsPalindrome();
                        break;
                    }
                case "11":
                    {
                        ShowIfNumberIsSuperPalindrome();

                        break;
                    }
                case "12":
                    {
                        CalculateAbsoluteValueOfDoubleNumber();

                        break;
                    }

                case "13":
                    {
                        ShowPalindromeAndSuperpalindromeBetween1And10000();
                        break;
                    }
            }
        }

        private static void ShowPalindromeAndSuperpalindromeBetween1And10000()
        {
            for (int k = 1; k <= 10000; k++)
            {
                string data = k.ToString();
                bool isPalindrome = IsStringPalindrome(data);
                if (isPalindrome)
                {
                    Console.WriteLine("Palindrome :" + k);
                }

                double kPow = Math.Pow(k, 2);
                string dataPow = kPow.ToString();
                bool isSuperPalindrome = IsStringPalindrome(dataPow);
                if (isSuperPalindrome)
                {
                    Console.WriteLine("Super Palindrome :" + kPow);
                }
            }
        }

        private static void CalculateAbsoluteValueOfDoubleNumber()
        {
            var number = GetDoubleNumberFromConsole();
            double valAbs;
            if (number >= 0)
            {
                valAbs = number;
            }
            else
            {
                valAbs = -number;
            }
            Console.WriteLine("Modulus of number " + valAbs);
        }

        private static void ShowIfNumberIsSuperPalindrome()
        {
            var number = GetIntNumberFromConsole();
            int mirrored = GetMirroredNumber(number);

            double numbPow = Math.Pow(number, 2);
            int mirPal = GetMirroredNumber(number);

            if ((mirrored == number) && (mirPal == numbPow))
            {
                Console.WriteLine("The number is super palindrom");
            }
            else
            {
                Console.WriteLine("The number is not super palindrom ");
            }
        }

        private static void ShowIfNumberIsPalindrome()
        {
            var number = GetIntNumberFromConsole();
            int mirrored = GetMirroredNumber(number);

            if (mirrored == number)
            {
                Console.WriteLine("The number is palindrom");
            }
            else
            {
                Console.WriteLine("The number is not palindrom ");
            }
        }

        private static void CalculateMirroredOfDoubleNumber()
        {
            var number = GetIntNumberFromConsole();
            int mirrored = GetMirroredNumber(number);
            Console.WriteLine("Mirrored number1 is " + mirrored);
        }

        private static void CalculateSquareRootOfDoubleNumber()
        {
            var number = GetNonNegativeDoubleNumberFromConsole();

            Console.WriteLine("Square root of number1 is " + Math.Sqrt(number));
        }

        private static void ShowIfNumberIsPrime()
        {
            var number = GetIntNumberFromConsole();
            bool isPrime = IsNumberPrime(number);

            if (isPrime)
            {
                Console.WriteLine("The Number is prime");
            }
            else
            {
                Console.WriteLine("The Number is not prime");
            }
        }

        private static void CalculateNumberParity()
        {
            var number = GetIntNumberFromConsole();
            if (number % 2 == 0)
            {
                Console.WriteLine(" Number is Even");
            }
            else
            {
                Console.WriteLine(" Number is Odd");
            }
        }

        private static void CalculateDoubleNumberExponentiation()
        {
            (double number1, double number2) = GetTwoDoubleNumbers();

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
        }

        private static void CalculateTwoDoubleNumberDivision()
        {
            (double number1, double number2) = GetTwoDoubleNumbers();

            if (number2 == 0)
            {
                Console.WriteLine("Number2 must not be 0");
            }
            else
            {

                double divResult = number1 / number2;

                Console.WriteLine("Division Result =" + divResult);
            }
        }

        private static void CalculateTwoDoubleNumberMultiplication()
        {
            (double number1, double number2) = GetTwoDoubleNumbers();

            double multiplicantionResult = number1 * number2;

            Console.WriteLine("Multiplicantion Result =" + multiplicantionResult);
        }

        private static void CalculateTwoDoubleNumberSubstraction()
        {
            (double number1, double number2) = GetTwoDoubleNumbers();

            double subResult = number1 - number2;

            Console.WriteLine("Substraction Result =" + subResult);
        }

        private static void CalculateTwoDoubleNumberSum()
        {
            (double number1, double number2) = GetTwoDoubleNumbers();

            double sumResult = number1 + number2;

            Console.WriteLine("Sum Result =" + sumResult);
        }

        private static bool IsNumberPrime(int number)
        {
            bool isPrime = true;
            if (number == 0 || number == 1)
            {
                isPrime = false;
            }
            else if (number == 2)
            {
                isPrime = true;
            }
            else if (number % 2 == 0)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 3; i < Math.Sqrt(number); i = i + 2)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            return isPrime;
        }

        private static void ShowOperationsMenu()
        {
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
        }

        private static bool IsStringPalindrome(string data)
        {
            bool isPalindrome = true;

            for (int i = 0; i < data.Length / 2; i++)
            {

                if (data[i] != data[(data.Length - 1) - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            return isPalindrome;
        }

        private static int GetMirroredNumber(int number)
        {
            int mirrored = 0;

            while (number != 0)
            {
                mirrored = mirrored * 10 + number % 10;
                number /= 10;
            }

            return mirrored;
        }

        private static (double, double) GetTwoDoubleNumbers()
        {
            var number1 = GetDoubleNumberFromConsole();
            var number2 = GetDoubleNumberFromConsole();
            return (number1, number2);
        }

        public static double GetDoubleNumberFromConsole()
        {
            double number;
            string theNumberAsString;
            bool cantParse;
            do
            {
                Console.WriteLine("Enter Double Number :");

                theNumberAsString = Console.ReadLine();
                cantParse = !double.TryParse(theNumberAsString, out number);
                if (cantParse)
                {
                    Console.WriteLine("The number is not valid ");
                }
            }
            while (cantParse);

            return number;
        }

        public static double GetNonNegativeDoubleNumberFromConsole()
        {
            double number;
            string theNumberAsString;
            bool cantParse;
            do
            {
                Console.WriteLine("Enter Double Number :");

                theNumberAsString = Console.ReadLine();
                cantParse = !double.TryParse(theNumberAsString, out number);
                if (cantParse || number < 0)
                {
                    Console.WriteLine("The number is not valid ");
                }
            }
            while (cantParse || number < 0);

            return number;
        }

        public static int GetIntNumberFromConsole()
        {
            int number;
            string theNumberAsString;
            bool cantParse;
            do
            {
                Console.WriteLine("Enter Int Number :");

                theNumberAsString = Console.ReadLine();
                cantParse = !int.TryParse(theNumberAsString, out number);
                if (cantParse)
                {
                    Console.WriteLine("The number is not valid ");
                }
            }
            while (cantParse);

            return number;
        }

    }
}