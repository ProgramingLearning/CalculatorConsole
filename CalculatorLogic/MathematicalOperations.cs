using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLogic
{
    public static class MathematicalOperations
    {
        public static double GetAbsoluteValue(double number)
        {
            double valAbs;
            if (number >= 0)
            {
                valAbs = number;
            }
            else
            {
                valAbs = -number;
            }

            return valAbs;
        }
        public static bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public static double GetDivResult(double number1, double number2)
        {
            return number1 / number2;
        }

        public static double GetSubResult(double number1, double number2)
        {
            return number1 - number2;
        }

        public static double GetMultiplicantionResult(double number1, double number2)
        {
            return number1 * number2;
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

        public static double GetSumResult(double number1, double number2)
        {
            return number1 + number2;
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
    }
}

