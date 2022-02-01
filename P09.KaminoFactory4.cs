using System;
using System.Linq;

namespace P09.KaminoFactory4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLength];
            string inputString = Console.ReadLine();

            int[] printArray = new int[arrayLength];
            int bigBigSequence = 0;
            int leftindex = int.MaxValue;
            int maxSum = 0;
            int numberCount = 0;
            int count = 1;

            while (inputString != "Clone them!")
            {
                int bigSequence = 1;
                int lIndex = int.MaxValue;
                int mSum = 0;
                array = inputString.Split("!").Select(int.Parse).ToArray();

                for (int k = 0; k < array.Length; k++)
                {
                    mSum += array[k];
                }


                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] == array[j] && array[i] == 1)
                        {
                            bigSequence++;
                            if (i < lIndex)
                            {
                                lIndex = i;
                            }
                        }
                        else if (array[i] != array[j])
                        {
                            i = j;
                            bigSequence = 1;
                        }

                        if (bigSequence > bigBigSequence)
                        {
                            bigBigSequence = bigSequence;
                            printArray = array;
                            numberCount = count;
                            maxSum = mSum;
                            leftindex = lIndex;

                        }
                        else if (bigSequence == bigBigSequence && lIndex < leftindex)
                        {
                            printArray = array;
                            numberCount = count;
                            maxSum = mSum;
                            leftindex = lIndex;

                        }
                        else if (bigSequence == bigBigSequence && i == leftindex && mSum > maxSum)
                        {
                            printArray = array;
                            numberCount = count;
                            maxSum = mSum;
                        }
                    }
                }
               
                inputString = Console.ReadLine();
                count++;
            }

            Console.WriteLine($"Best DNA sample {numberCount} with sum: {maxSum}.");
            Console.WriteLine(String.Join(" ", printArray));
        }
    }
}
