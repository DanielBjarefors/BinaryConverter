using System;
using System.Collections.Generic;

namespace DecimalToBinaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = 0;
            
            while (input<1)
            {
                Console.WriteLine("Write a number between 1 and whatever");

                double.TryParse(Console.ReadLine(), out input);
            }

           

            Lista.FillBinaryList(input);

            


        }
    }
}
