using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] numbers = input.Select(int.Parse).ToArray();
            if (numbers.Length == 1)
            {
                Console.WriteLine($"{String.Join("", input)} is already condensed to number");
            }
            else
            {
                int[] sum = new int[numbers.Length];

                for (int i = 0; i < numbers.Length; i++)
                {
                    for (int j = 0; j < numbers.Length - 1; j++)
                    {
                        sum[j] = numbers[j] + numbers[j + 1];
                    }
                    sum = numbers;
                }
                Console.WriteLine(sum[0]);
            }
        }
    }
}
