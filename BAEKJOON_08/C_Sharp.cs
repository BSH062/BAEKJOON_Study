using System;

namespace C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int year = int.Parse(input);
            int BCyear = 2541 - 1998;
            int result = year - BCyear;

            Console.WriteLine(result);
        }
    }
}
