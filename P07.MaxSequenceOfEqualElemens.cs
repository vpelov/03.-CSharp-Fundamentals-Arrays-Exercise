using System;
using System.Linq;

namespace P07.MaxSequenceOfEqualElemens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberCount = 0;
            int digit = 0;


            for (int i = 0; i < array.Length; i++)
            {
                int numberCountOne = 1;
                int digitOne = 0;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        numberCountOne++;
                        digitOne = array[i];
                    }
                    else
                    {
                        break;
                    }

                    if (numberCountOne > numberCount)
                    {
                        numberCount = numberCountOne;
                        digit = digitOne;
                    }
                }
            }

            int[] arrayNew = new int[numberCount];

            for (int i = 0; i < arrayNew.Length; i++)
            {
                arrayNew[i] = digit;
            }

            Console.WriteLine(String.Join(" ", arrayNew));
        }
    }
}
