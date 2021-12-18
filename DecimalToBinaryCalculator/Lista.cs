using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinaryCalculator
{
    class Lista
    {
        public static void FillBinaryList(double input)
        {
            List<int> BinaryList = new List<int>();

            for (int i = 1; i < input; i *= 2)
            {
                BinaryList.Add(i);
            }

            List<int> BinaryNr = new List<int>();

            while (BinaryList.Count > 0)
            {
                if (BinaryList[^1] <= input)
                {
                    BinaryNr.Add(1);
                    input = input - BinaryList[^1];
                    BinaryList.RemoveAt(BinaryList.Count - 1);
                }
                else
                {
                    BinaryNr.Add(0);
                    BinaryList.RemoveAt(BinaryList.Count - 1);
                }

            }

            Console.WriteLine();

            foreach (var e in BinaryNr)
            {
                Console.Write(e);
            }

            Console.WriteLine();
        }
    }


}

