using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _04_TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] values = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                values[i]= int.Parse(input[i]);
            }


            bool flag = false;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = i + 1; j < values.Length; j++)
                {
                    for (int k = 0; k < values.Length; k++)
                    {
                        if (values[i] + values[j] == values[k])
                        {
                            Console.WriteLine("{0} + {1} == {2}", values[i], values[j], values[k]);
                            flag = true;
                            break;
                        }
                    }
                }
            }
            if (!flag)
            {
                Console.WriteLine("No");
            }
        }
    }
}
