using System;
using System.Linq;

namespace P04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] currentArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numberRotation = int.Parse(Console.ReadLine());

            int[] rotatingArray = new int[currentArray.Length];
            int numberNewRotation = 0;

            if (numberRotation >= currentArray.Length)
            {
                numberNewRotation = numberRotation % currentArray.Length;
            }
            else
            {
                numberNewRotation = numberRotation;
            }

            for (int i = 0; i < currentArray.Length; i++)
            {
                if (numberNewRotation >= currentArray.Length)
                {
                    numberNewRotation = numberNewRotation - currentArray.Length;
                }
                rotatingArray[i] = currentArray[numberNewRotation];
                numberNewRotation++;
            }

            foreach (int item in rotatingArray)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
