using System;
using System.Linq;

namespace FizzBuzz
{
    public static class FizzBuzzExtensions
    {
        public static bool IsAFactorOf(this int source, int target)
        {
            return target % source == 0;
        }
    }

    public class Program
    {
        public static string GetFizzBuzz(int number)
        {
            if (15.IsAFactorOf(number))
            {
                return string.Format("{0} - FizzBuzz", number);
            }

            if (3.IsAFactorOf(number))
            {
                return string.Format("{0} - Fizz", number);
            }

            if (5.IsAFactorOf(number))
            {
                return string.Format("{0} - Buzz", number);
            }
            return number.ToString();
        }

        static void Main()
        {
            Enumerable.Range(0, 100)
                .Select(GetFizzBuzz)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
