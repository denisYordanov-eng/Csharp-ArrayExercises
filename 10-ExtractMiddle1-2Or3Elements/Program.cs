using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ExtractMiddle1_2Or3Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] numbers = input.Select(int.Parse).ToArray();

            int middleIndex = numbers.Length / 2;
            if (numbers.Length == 1)
            {
                Console.WriteLine($"{numbers[0]}");
            }
            else if (numbers.Length % 2 == 0)
            {
                EvenNum(numbers, middleIndex);
            }
            else if (numbers.Length % 2 != 0)
            {
                OddNum(numbers, middleIndex);
            }
        }
        static void EvenNum(int[] numbers, int middleIndex)
        {
            Console.Write("{" + $" {numbers[middleIndex - 1]}, {numbers[middleIndex]} "+"}");  
           
        }
        static void OddNum(int[] numbers, int middleIndex)
        {
            Console.Write("{" + $" {numbers[middleIndex - 1]}, {numbers[middleIndex]}, {numbers[middleIndex + 1]} " + "}");
        }
    }
}
