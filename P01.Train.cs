using System;
using System.Linq;

namespace P01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numberPeopleTrein = int.Parse(Console.ReadLine());

            int[] peopleTrainArray = new int[numberPeopleTrein];

            for (int i = 0; i < peopleTrainArray.Length; i++)
            {
                int number = int.Parse(Console.ReadLine());
                peopleTrainArray[i] = number;
            }

            int sum = 0;

            foreach (int item in peopleTrainArray)
            {
                Console.Write($"{item} ");
                sum += item;
            }

            Console.WriteLine();
            Console.WriteLine(sum);

        }
    }
}
