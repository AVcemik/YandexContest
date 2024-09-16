using System;

namespace Task_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            long result = 1;

            if (N >= 1000003) { result = 0; }
            else
            {
                for (long i = 1; i <= N; i++)
                {
                    result *= i;
                    result %= 1000003;
                }
            }

            Console.WriteLine(result);
        }
    }
}
