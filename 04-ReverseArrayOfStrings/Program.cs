using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string[] words = Console.ReadLine().Split(' ').ToArray();
            Console.WriteLine(String.Join(" ", words.Reverse()));
           
        }
    }    
}
