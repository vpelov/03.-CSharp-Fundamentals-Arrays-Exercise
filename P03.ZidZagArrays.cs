using System;
using System.Linq;

namespace P03.ZidZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengthArrays = int.Parse(Console.ReadLine());

            int[] firstArray = new int[lengthArrays];
            int[] secondArray = new int[lengthArrays];

            for (int i = 0; i < firstArray.Length; i++)   // ------------------------------
            {                                             //
                string[] input = new string[2];           //
                input = Console.ReadLine().Split(" ");    //  Read input from two elements
                                                          //
                firstArray[i] = int.Parse(input[0]);      //
                secondArray[i] = int.Parse(input[1]);     //--------------------------------
            }

            int[] oneArray = new int[lengthArrays];
            int[] twoArray = new int[lengthArrays];


            for (int i = 0; i < lengthArrays; i++)        //------------------------------
            {                                             //
                if (i % 2 == 0)                           //
                {                                         //
                    oneArray[i] = firstArray[i];          //
                    twoArray[i] = secondArray[i];         //   Making Zig Zag 
                }                                         //
                else if (i % 2 != 0)                      //
                {                                         //
                    oneArray[i] = secondArray[i];         //
                    twoArray[i] = firstArray[i];          //
                }                                         //
            }                                             //-----------------------------

            foreach (int item in oneArray)                //---------------------------
            {                                             //
                Console.Write($"{item} ");                //
            }                                             //
            Console.WriteLine();                          //   Print
            foreach (int item in twoArray)                //
            {                                             //
                Console.Write($"{item} ");                //
            }                                             //------------------------------

        }
    }
}
