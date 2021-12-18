using System;
using System.Collections.Generic;

namespace DecimalToBinaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;

            do
            {
                Console.WriteLine("Write a number between 1 and whatever");
            } while (input > 1 && int.TryParse(Console.ReadLine(), out input));

            Lista.FillBinaryList(input);
        }
    }
}
