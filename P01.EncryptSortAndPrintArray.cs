using System;
using System.Linq;

namespace P01.EncryptSortAndPrintArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberString = int.Parse(Console.ReadLine());

            int[] printArray = new int[numberString];

            for (int i = 0; i < numberString; i++)
            {
                string name = Console.ReadLine();

                int vowelSum = 0;
                int consonantSum = 0;
                int totalSum = 0;

                for (int j = 0; j < name.Length; j++)
                {

                    char currentSymbol = name[j];
                    int currentDigit = name[j];


                    if (currentSymbol == 'A' || currentSymbol == 'a' || currentSymbol == 'E' || currentSymbol == 'e' || currentSymbol == 'I' || currentSymbol == 'i' || currentSymbol == 'O' || currentSymbol == 'o' || currentSymbol == 'U' || currentSymbol == 'u')
                    {
                        vowelSum += currentDigit * name.Length;
                    }
                    else
                    {
                        consonantSum += currentDigit / name.Length;
                    }

                    totalSum = vowelSum + consonantSum;

                }
                printArray[i] = totalSum;
            }

            int[] printArraySort = new int[printArray.Length];

            for (int i = 0; i < printArray.Length; i++)
            {
                int min = int.MaxValue;

                for (int j = 0; j < printArray.Length; j++)
                {
                    if (min > printArray[j])
                    {
                        min = printArray[j];
                    }
                }
                printArraySort[i] = min;

                for (int k = 0; k < printArray.Length; k++)
                {
                    if (min == printArray[k])
                    {
                        printArray[k] = int.MaxValue;
                    }
                }
            }

            foreach (int item in printArraySort)
            {
                Console.WriteLine(item);
            }

        }
    }
}
