using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsole
{
    internal static class CalculatorLogic
    {
        public static void DoOperation()
        {
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "1":
                    {
                        CalculatorOperations.CalculateTwoDoubleNumberSum();
                        break;
                    }

                case "2":
                    {
                        CalculatorOperations.CalculateTwoDoubleNumberSubstraction();
                        break;
                    }
                case "3":
                    {
                        CalculatorOperations.CalculateTwoDoubleNumberMultiplication();
                        break;
                    }
                case "4":
                    {
                        CalculatorOperations.CalculateTwoDoubleNumberDivision();
                        break;
                    }
                case "5":
                    {
                        CalculatorOperations.CalculateDoubleNumberExponentiation();
                        break;
                    }

                case "6":
                    {
                        CalculatorOperations.CalculateNumberParity();
                        break;
                    }
                case "7":
                    {
                        CalculatorOperations.ShowIfNumberIsPrime();

                        break;
                    }
                case "8":
                    {
                        CalculatorOperations.CalculateSquareRootOfDoubleNumber();

                        break;
                    }
                case "9":
                    {
                        CalculatorOperations.CalculateMirroredOfDoubleNumber();
                        break;
                    }
                case "10":
                    {
                        CalculatorOperations.ShowIfNumberIsPalindrome();
                        break;
                    }
                case "11":
                    {
                        CalculatorOperations.ShowIfNumberIsSuperPalindrome();

                        break;
                    }
                case "12":
                    {
                        CalculatorOperations.CalculateAbsoluteValueOfDoubleNumber();

                        break;
                    }

                case "13":
                    {
                        CalculatorOperations.ShowPalindromeAndSuperpalindromeBetween1And10000();
                        break;
                    }
            }
        }

    }
}
