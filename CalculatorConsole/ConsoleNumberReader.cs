using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsole
{
    internal static class ReadNumber
    {
        public static double GetDoubleNumberFromConsole()
        {
            double number;
            string theNumberAsString;
            bool cantParse;
            do
            {
                Console.WriteLine("Enter Double Number= ");

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
                Console.WriteLine("Enter Double Number= ");

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
                Console.WriteLine("Enter Int Number= ");

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
        public static (double, double) GetTwoDoubleNumbers()
        {
            var number1 = GetDoubleNumberFromConsole();
            var number2 = GetDoubleNumberFromConsole();
            return (number1, number2);
        }

    }
}
