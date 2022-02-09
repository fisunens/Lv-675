using System;

namespace Lecture3
{


    class Program
    {


        static void Main()
        {
            Console.WriteLine("Enter year:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month:");
            int month = Convert.ToInt32(Console.ReadLine());
            int count_of_day = DateTime.DaysInMonth(year, month);
            Console.Write($"In {month} month {year} year {count_of_day} days!");
            Console.ReadKey();

        }
    }
}