using System;

namespace C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] myChess = Array.ConvertAll(input,s=>int.Parse(s));
            int[] chess = { 1, 1, 2, 2, 2, 8 };
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(chess[i] - myChess[i]+" ");
            }
        }
    }
}
