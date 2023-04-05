using CalculatorLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsole
{
    public static class CalculatorManager
    {
        public static void CalculateAbsoluteValueOfDoubleNumber()
        {
            var number = ConsoleNumberReader.GetDoubleNumberFromConsole();
            double valAbs = MathematicalOperations.GetAbsoluteValue(number);
            Console.WriteLine("Modulus of number " + valAbs);
        }

        public static void CalculateMirroredOfDoubleNumber()
        {
            var number = ConsoleNumberReader.GetIntNumberFromConsole();
            int mirrored = MathematicalOperations.GetMirroredNumber(number);
            Console.WriteLine("Mirrored number is " + mirrored);
        }

        public static void CalculateSquareRootOfDoubleNumber()
        {
            var number = ConsoleNumberReader.GetNonNegativeDoubleNumberFromConsole();

            Console.WriteLine("Square root is " + Math.Sqrt(number));
        }

        public static void CalculateNumberParity()
        {
            var number = ConsoleNumberReader.GetIntNumberFromConsole();
            if (MathematicalOperations.IsNumberEven(number))
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }

        public static void CalculateDoubleNumberExponentiation()
        {
            (double baseNumber, double exponent) = ConsoleNumberReader.GetTwoDoubleNumbers();

            var result = Math.Pow(baseNumber, exponent);

            Console.WriteLine("Exponentiation Result= " + result);
        }

        public static void CalculateTwoDoubleNumberDivision()
        {
            (double number1, double number2) = ConsoleNumberReader.GetTwoDoubleNumbers();

            if (number2 == 0)
            {
                Console.WriteLine("Number2 must not be 0");
            }
            else
            {
                double divResult = MathematicalOperations.GetDivResult(number1, number2);

                Console.WriteLine("Division Result= " + divResult);
            }
        }

        public static void CalculateTwoDoubleNumberMultiplication()
        {
            (double number1, double number2) = ConsoleNumberReader.GetTwoDoubleNumbers();

            double multiplicantionResult = MathematicalOperations.GetMultiplicantionResult(number1, number2);

            Console.WriteLine("Multiplicantion Result= " + multiplicantionResult);
        }

        public static void CalculateTwoDoubleNumberSubstraction()
        {
            (double number1, double number2) = ConsoleNumberReader.GetTwoDoubleNumbers();

            double subResult = MathematicalOperations.GetSubResult(number1, number2);

            Console.WriteLine("Substraction Result= " + subResult);
        }

        public static void CalculateTwoDoubleNumberSum()
        {
            (double number1, double number2) = ConsoleNumberReader.GetTwoDoubleNumbers();

            double sumResult = MathematicalOperations.GetSum(number1, number2);

            Console.WriteLine("Sum Result= " + sumResult);
        }
        public static void ShowIfNumberIsPrime()
        {
            var number = ConsoleNumberReader.GetIntNumberFromConsole();
            bool isPrime = MathematicalOperations.IsNumberPrime(number);

            if (isPrime)
            {
                Console.WriteLine("The Number is prime");
            }
            else
            {
                Console.WriteLine("The Number is not prime");
            }
        }
        public static void ShowIfNumberIsPalindrome()
        {
            var number = ConsoleNumberReader.GetIntNumberFromConsole();
            int mirrored = MathematicalOperations.GetMirroredNumber(number);

            if (mirrored == number)
            {
                Console.WriteLine("The number is palindrom");
            }
            else
            {
                Console.WriteLine("The number is not palindrom ");
            }
        }

        public static void ShowIfNumberIsSuperPalindrome()
        {
            var number = ConsoleNumberReader.GetIntNumberFromConsole();
            int mirrored = MathematicalOperations.GetMirroredNumber(number);

            double numbPow = Math.Pow(number, 2);
            int mirPal = MathematicalOperations.GetMirroredNumber(number);

            if ((mirrored == number) && (mirPal == numbPow))
            {
                Console.WriteLine("The number is super palindrom");
            }
            else
            {
                Console.WriteLine("The number is not super palindrom ");
            }
        }
        public static void ShowPalindromeAndSuperpalindromeBetween1And10000()
        {
            for (int k = 1; k <= 10000; k++)
            {
                string data = k.ToString();
                bool isPalindrome = MathematicalOperations.IsStringPalindrome(data);
                if (isPalindrome)
                {
                    Console.WriteLine("Palindrome= " + k);

                    double kPow = Math.Pow(k, 2);
                    string dataPow = kPow.ToString();
                    bool isSuperPalindrome = MathematicalOperations.IsStringPalindrome(dataPow);
                    if (isSuperPalindrome)
                    {
                        Console.WriteLine("Super Palindrome= " + kPow);
                    }
                }

                
            }
        }
    }
}
