using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _05_SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];
                if(currentNum % 2 == 0)
                {
                    sum += currentNum;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
