/*1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.
*/

using System;

namespace excercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, d;
            Console.WriteLine("enter numbers n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter value of divider");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("numbers " + n + " divided by " + d + " is:- ");

            for (int i = 0; i <= n; i++)
            {
                if (i % d == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}