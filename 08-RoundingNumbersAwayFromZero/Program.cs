using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RoundingNumbersAwayFromZero
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            double[] values = input.Select(double.Parse).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                double roundNumber = (values[i]);
                Console.WriteLine("{0} => {1}", values[i], Math.Round(roundNumber, MidpointRounding.AwayFromZero));
            }
        }
    }
}
