
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
                CalculatorService.ShowOperationsMenu();
                CalculatorService.DoOperation();
                Console.WriteLine("Would you like to do another operation? y/n");
            } while (Console.ReadLine().ToLower() == "y");
        }
    }
}

       
