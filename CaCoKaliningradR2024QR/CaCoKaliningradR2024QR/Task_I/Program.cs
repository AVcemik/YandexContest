using System;

namespace Task_I
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            long[] a = Array.ConvertAll(Console.ReadLine()!.Split(' '), long.Parse);

            int M = int.Parse(Console.ReadLine()!);

            string[] operation;

            for (int i = 0; i < M; i++)
            {
                operation = Console.ReadLine()!.Split(" ");                

                switch (operation[0])
                {
                    case "1":
                        DepositUpLine(a, int.Parse(operation[1]) - 1, int.Parse(operation[2]), int.Parse(operation[3]));
                        break;
                    case "2":
                        DepositUpMultiply(a, int.Parse(operation[1]) - 1, int.Parse(operation[2]));
                        break;
                    default:
                        SumDeposit(a, int.Parse(operation[1]) - 1, int.Parse(operation[2]));
                        break;
                }
            }
        }

        public static void DepositUpLine(long[] a, int start, int end, long valueToAdd)
        {
            int count = end - start;

            
            if (count % 8 == 0)
            {
                int stop = count / 8;
                for (int j = 0; j < stop; j++)
                {
                    a[start + j] += valueToAdd;
                    a[start + j + stop] += valueToAdd;
                    a[start + j + stop * 2] += valueToAdd;
                    a[start + j + stop * 3] += valueToAdd;
                    a[start + j + stop * 4] += valueToAdd;
                    a[start + j + stop * 5] += valueToAdd;
                    a[start + j + stop * 6] += valueToAdd;
                    a[start + j + stop * 7] += valueToAdd;
                }
            }
            else if (count % 4 == 0)
            {
                int stop = count / 4;
                for (int j = 0; j < stop; j++)
                {
                    a[start + j] += valueToAdd;
                    a[start + j + stop] += valueToAdd;
                    a[start + j + stop * 2] += valueToAdd;
                    a[start + j + stop * 3] += valueToAdd;
                }
            }
            if (count % 2 == 0)
            {
                int stop = count / 2;
                for (int j = 0; j < stop; j++)
                {
                    a[start + j] += valueToAdd;
                    a[start + j + stop] += valueToAdd;
                }
            }
            else
            {
                for (int j = start; j < end; j++)
                {
                    a[j] += valueToAdd;
                }
            }
        }
        public static void DepositUpMultiply(long[] a, int start, long valueToAdd)
        {
            int step = start + 1;
            for (int j = start; j < a.Length; j += step)
            {
                a[j] += valueToAdd;
            }
        }
        public static void SumDeposit(long[] a, int start, int end)
        {
            long result = 0;
            for (int j = start; j < end; j++)
            {
                result += a[j];
            }

            Console.WriteLine(result);
            Console.Out.Flush();
        }

        public static void SumDepositOperationOne()
        {

        }
    }
}
