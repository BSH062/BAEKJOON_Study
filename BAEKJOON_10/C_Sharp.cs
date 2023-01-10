using System;


namespace C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input= Console.ReadLine().Split();
            int[] inputs = Array.ConvertAll(input, s => int.Parse(s));
            int a = inputs[0], b = inputs[1], c = inputs[2];

            int result_a = (a + b) % c;
            int result_b = ((a % c) + (b % c)) % c;
            int result_c = (a * b) % c;
            int result_d = ((a % c) * (b % c)) % c;

            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n", result_a, result_b, result_c, result_d);
        }
    }
}
