using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ReverseArrayOfStrings_AnotherWay
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            string[] reversedWords = new string[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                reversedWords[i] = words[words.Length - 1 - i];
            }
           
                Console.WriteLine(String.Join(" ", reversedWords));
            
        }
    }
}
