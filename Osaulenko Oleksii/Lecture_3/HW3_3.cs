using System;

namespace Lecture3
{


    class Program
    {


        static void Main()
        {
            bool positive = true;
            int[] data = new int[10];
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine("Enter integer number:");
                data[i] = Convert.ToInt32(Console.ReadLine());
                if (data[i] < 0)
                {
                    positive = false;
                }
            }

            if (positive)
            {
                int sum_first_five = 0;
                for (int j = 0; j < 5; j++)
                {
                    sum_first_five += data[j];
                }
                Console.WriteLine($"All elements are positive. Sum of first five elements = {sum_first_five}.");
            }
            else
            {
                int prod_last_five = 1;
                for (int k = 5; k < data.Length; k++)
                {
                    prod_last_five *= data[k];
                }
                Console.WriteLine($"Not all elements are positive. Product of last five elements = {prod_last_five}.");
            }
        }
    }
}