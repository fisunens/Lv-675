using System;
using System.Linq;

namespace Lecture3
{


    class Program
    {


        static void Main()
        {
            string[] letters = { "a", "o", "i", "e" };
            string input_str = Console.ReadLine();

            foreach (string i in letters)
            {
                int count = input_str.Count(x => i.Contains(x));
                Console.WriteLine($"Letter \"{i}\" meets {count} times");

            }
            Console.ReadKey();

        }
    }
}