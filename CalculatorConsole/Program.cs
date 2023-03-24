
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
                CalculatorLogic.DoOperation();
                Console.WriteLine("Would you like to do another operation? y/n");
            } while (Console.ReadLine().ToLower() == "y");
        }

        
        
        private static void ShowOperationsMenu()
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
    }
}

       
