using System;
using System.Linq;

namespace P06.EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool isEqualSums = true;

            for (int i = 0; i < inputArray.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += inputArray[j];
                }

                for (int k = i + 1; k < inputArray.Length; k++)
                {
                    rightSum += inputArray[k];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    isEqualSums = false;
                }
            }
            if (isEqualSums)
            {
                Console.WriteLine("no");
            }

        }
    }
}
