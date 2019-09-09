using System;

namespace HackerRank_Simple_Array_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration of Integer and converting it to a Int32 type.
            int n = Convert.ToInt32(Console.ReadLine());
            //Creating an array of substrings
            string[] arr = Console.ReadLine().Split(' ');
            //Returns the sum value
            long sum = 0;
            //For loop calculates the sum of the array and convert it to Int64 type. It also grabs the array of sub strings.
            for (int i = 0; i < n; i++)
            {
                sum += Convert.ToInt64(arr[i]);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
