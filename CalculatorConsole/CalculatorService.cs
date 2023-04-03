using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsole
{
    internal static class CalculatorService
    {
        public static void ShowOperationsMenu()
        {
            Console.WriteLine("\n Choose an operation : ");

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

        public static void DoOperation()

        {
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "1":
                    {
                        CalculatorManager.CalculateTwoDoubleNumberSum();
                        break;
                    }

                case "2":
                    {
                        CalculatorManager.CalculateTwoDoubleNumberSubstraction();
                        break;
                    }
                case "3":
                    {
                        CalculatorManager.CalculateTwoDoubleNumberMultiplication();
                        break;
                    }
                case "4":
                    {
                        CalculatorManager.CalculateTwoDoubleNumberDivision();
                        break;
                    }
                case "5":
                    {
                        CalculatorManager.CalculateDoubleNumberExponentiation();
                        break;
                    }

                case "6":
                    {
                        CalculatorManager.CalculateNumberParity();
                        break;
                    }
                case "7":
                    {
                        CalculatorManager.ShowIfNumberIsPrime();

                        break;
                    }
                case "8":
                    {
                        CalculatorManager.CalculateSquareRootOfDoubleNumber();

                        break;
                    }
                case "9":
                    {
                        CalculatorManager.CalculateMirroredOfDoubleNumber();
                        break;
                    }
                case "10":
                    {
                        CalculatorManager.ShowIfNumberIsPalindrome();
                        break;
                    }
                case "11":
                    {
                        CalculatorManager.ShowIfNumberIsSuperPalindrome();

                        break;
                    }
                case "12":
                    {
                        CalculatorManager.CalculateAbsoluteValueOfDoubleNumber();

                        break;
                    }

                case "13":
                    {
                        CalculatorManager.ShowPalindromeAndSuperpalindromeBetween1And10000();
                        break;
                    }
            }
        }

    }
}
