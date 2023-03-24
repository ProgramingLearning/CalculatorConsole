using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsole
{
    internal static class CalculatorOperations
    {

        public static void CalculateAbsoluteValueOfDoubleNumber()
        {

            var number = ReadNumber.GetDoubleNumberFromConsole();
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
        public static int GetMirroredNumber(int number)
        {
            int mirrored = 0;

            while (number != 0)
            {
                mirrored = mirrored * 10 + number % 10;
                number /= 10;
            }

            return mirrored;
        }
        public static void CalculateMirroredOfDoubleNumber()
        {
            var number = ReadNumber.GetIntNumberFromConsole();
            int mirrored = GetMirroredNumber(number);
            Console.WriteLine("Mirrored number is " + mirrored);
        }
        public static void CalculateSquareRootOfDoubleNumber()
        {
            var number = ReadNumber.GetNonNegativeDoubleNumberFromConsole();

            Console.WriteLine("Square root is " + Math.Sqrt(number));
        }
        public static void CalculateNumberParity()
        {
            var number = ReadNumber.GetIntNumberFromConsole();
            if (number % 2 == 0)
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
            (double number1, double number2) = ReadNumber.GetTwoDoubleNumbers();

            if (number2 == 0)
            {
                Console.WriteLine("Exponentiation Result = 1");
            }
            else if (number2 == 1)
            {
                Console.WriteLine("Exponentiation Result= " + number1);
            }
            else
            {
                double expoResult = 1;
                for (int i = 0; i < number2; i++)
                {
                    expoResult *= number1;
                }
                Console.WriteLine("Exponentiation Result= " + expoResult);
            }
        }

        public static void CalculateTwoDoubleNumberDivision()
        {
            (double number1, double number2) = ReadNumber.GetTwoDoubleNumbers();

            if (number2 == 0)
            {
                Console.WriteLine("Number2 must not be 0");
            }
            else
            {

                double divResult = number1 / number2;

                Console.WriteLine("Division Result= " + divResult);
            }
        }

        public static void CalculateTwoDoubleNumberMultiplication()
        {
            (double number1, double number2) = ReadNumber.GetTwoDoubleNumbers();

            double multiplicantionResult = number1 * number2;

            Console.WriteLine("Multiplicantion Result= " + multiplicantionResult);
        }

        public static void CalculateTwoDoubleNumberSubstraction()
        {
            (double number1, double number2) = ReadNumber.GetTwoDoubleNumbers();

            double subResult = number1 - number2;

            Console.WriteLine("Substraction Result= " + subResult);
        }

        public static void CalculateTwoDoubleNumberSum()
        {
            (double number1, double number2) = ReadNumber.GetTwoDoubleNumbers();

            double sumResult = number1 + number2;

            Console.WriteLine("Sum Result= " + sumResult);
        }

        public static bool IsNumberPrime(int number)
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
                for (int i = 3; i < Math.Sqrt(number); i += 2)
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
        public static bool IsStringPalindrome(string data)
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
        public static void ShowIfNumberIsPrime()
        {
            var number = ReadNumber.GetIntNumberFromConsole();
            bool isPrime = CalculatorOperations.IsNumberPrime(number);

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
            var number = ReadNumber.GetIntNumberFromConsole();
            int mirrored = CalculatorOperations.GetMirroredNumber(number);

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
            var number = ReadNumber.GetIntNumberFromConsole();
            int mirrored = CalculatorOperations.GetMirroredNumber(number);

            double numbPow = Math.Pow(number, 2);
            int mirPal = CalculatorOperations.GetMirroredNumber(number);

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
                bool isPalindrome = CalculatorOperations.IsStringPalindrome(data);
                if (isPalindrome)
                {
                    Console.WriteLine("Palindrome= " + k);
                }

                double kPow = Math.Pow(k, 2);
                string dataPow = kPow.ToString();
                bool isSuperPalindrome = CalculatorOperations.IsStringPalindrome(dataPow);
                if (isSuperPalindrome)
                {
                    Console.WriteLine("Super Palindrome= " + kPow);
                }
            }
        }
    }



}

