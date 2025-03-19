using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] arr2 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            bool areEqual = true;
            int sumArray = 0;
            
            for (int i = 0; i < arr1.Length; i++)
            {
                sumArray += arr1[i];

                if (arr1[i] != arr2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    areEqual = false;
                    break;
                }
            }
            if (areEqual == true)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sumArray}");
            }
            
        }
    }
}
