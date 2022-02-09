using System;

namespace P01.LargestCommonEnd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');

            CheckLongSequence(firstArray, secondArray);

        }

        static void CheckLongSequence(string[] arrayOne, string[] arrayTwo)
        {
            int countLeft = 0;
            int countRight = 0;

            int minArray = Math.Min(arrayOne.Length , arrayTwo.Length);

            for (int i = 0; i < minArray; i++)
            {
                if (arrayOne[i] == arrayTwo[i])
                {
                    countLeft++;
                }

                if (arrayOne[arrayOne.Length -1 - i] == arrayTwo[arrayTwo.Length - 1 - i] )
                {
                    countRight++;
                }
            }

            int maxNumber = Math.Max(countLeft, countRight);
            Console.WriteLine(maxNumber);
        
        }
    }
}
