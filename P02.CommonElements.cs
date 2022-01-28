using System;

namespace P02.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(" ");
            string[] secondArray = Console.ReadLine().Split(" ");

            string[] compareElements = new string[secondArray.Length];
            int count = 0;

            for (int i = 0; i < secondArray.Length; i++)
            {
                for (int j = 0; j < firstArray.Length; j++)
                {
                    if (secondArray[i] == firstArray[j])
                    {
                        compareElements[count] = secondArray[i];
                        count++;
                    }
                }
            }

            Console.WriteLine(String.Join(" ", compareElements));
        }
    }
}
