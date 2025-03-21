using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_LastKNumbersSumsSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            long step = long.Parse(Console.ReadLine());

            long[] sequence = new long[number];
            sequence[0] = 1;
            for (long i = 1; i < number; i++)
            {
                long sum = 0;
               long toSteps = 1;
                long last = i - 1;

              while(last >= 0 && toSteps <= step)
                {
                    sum += sequence[last--];
                    toSteps++;
                }
                sequence[i] = sum;
            }

            foreach (var value in sequence)
            {
                Console.Write(value + " ");
            }
        }
    }
}
