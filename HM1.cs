using System;

namespace HM01
{
    class HelloName
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"area of square = {a * a} and perimeter is {a * 4}");

            Console.WriteLine("What is yr name?");
            string Name = Console.ReadLine();
            Console.WriteLine($"How old are you {Name}?");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"OMG {Name}, really {Age}?");

            Console.WriteLine($"Hey {Name}, wanna see magick of circle? Type any number...");
            double r = Convert.ToDouble(Console.ReadLine());
            double length = 2 * 3.14 * r;
            double area = 3.14 * r * r;
            double volume = 4 / 3 * 3.14 * r * r * r;

            Console.WriteLine($"Lenght of your circle = {length}, area = {area}, and volume = {volume}");

        }
    }
}
