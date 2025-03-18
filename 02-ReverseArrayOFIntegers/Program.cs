using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ReverseArrayOFIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var number = new int[n];
            for(int i = 0; i < n; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
            }
            for(int i = n-1 ; i >= 0; i--)
            {
                Console.WriteLine(number[i]);
            }
        }
    }
}
