using System;

namespace FizzBuzz
{
    internal class Program
    {
        /*  FizzBuzz
         *  a user should be able to enter the starting and ending count
            a user should be able to enter these values in any order
            a user should be able to get the number of times fizz, buzz, and fizzbuzz appear
            a user should be able to set new values for fizz, buzz, and fizzbuzz
         */
        static void Main(string[] args)
        {
            var countFizz = 0;
            var countBuzz = 0;
            var countFizzBuzz = 0;

            var countRange = new[] {0,0};
            Console.WriteLine("Please enter the value to begin counting from:");
            countRange[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the value to begin counting from:");
            countRange[1] = int.Parse(Console.ReadLine());

            if(countRange[0] > countRange[1])
            {
                var tempSwap = countRange[0];
                countRange[0] = countRange[1];
                countRange[1] = tempSwap;
            }

            Console.WriteLine("");
        }


    }
}
