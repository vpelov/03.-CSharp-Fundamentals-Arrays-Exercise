using System;
using System.Linq;

namespace P011.ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int numberMaxEvenOdd = 0;
            int numberMinEvenOdd = 0;
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] arrayCommand = command.Split();
                string evenOdd = arrayCommand[1].ToString();


                if (arrayCommand[0] == "exchange")
                {
                    int inputIndex = int.Parse(arrayCommand[1]);

                    if (inputIndex > array.Length - 1)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        array = GetReArray(array, inputIndex);
                    }
                }
                else if (arrayCommand[0] == "max")
                {

                    numberMaxEvenOdd = GetMaxEvenOddNumber(array, evenOdd);
                    if (numberMaxEvenOdd < 0)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(numberMaxEvenOdd);
                    }
                }
                else if (arrayCommand[0] == "min")
                {
                    numberMinEvenOdd = GetMinEvenOddNumber(array, evenOdd);
                    if (numberMinEvenOdd < 0)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(numberMinEvenOdd);
                    }
                }
                else if (arrayCommand[0] == "first")
                {
                    string number = arrayCommand[1];
                    int numberCount = int.Parse(number);   //string number => to int numberCount

                    string oddEven = arrayCommand[2];

                    if (numberCount > array.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        int[] arr = GetFirstCountEvenOdd(array, numberCount, oddEven);
                        if (arr.Length == 0)
                        {
                            Console.Write("[");
                            Console.WriteLine("]");
                        }
                        else
                        {
                            Console.Write("[");
                            for (int i = 0; i < arr.Length; i++)
                            {
                                if (arr[i] == 0)
                                {
                                    break;
                                }

                                if (i == 0)
                                {
                                    Console.Write(arr[i]);
                                }
                                else
                                {
                                    Console.Write($", {arr[i]}");
                                }
                            }
                            Console.WriteLine("]");
                        }
                    }
                }
                else if (arrayCommand[0] == "last")
                {
                    string number = arrayCommand[1];
                    int numberCount = int.Parse(number);   //string number => to int numberCount

                    string oddEven = arrayCommand[2];

                    if (numberCount > array.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        int[] arr = GetLastCountEvenOdd(array, numberCount, oddEven);
                        if (arr.Length == 0)
                        {
                            Console.Write("[");
                            Console.WriteLine("]");
                        }
                        else
                        {
                            Console.Write("[");
                            for (int i = 0; i < arr.Length; i++)
                            {
                                if (arr[i] == 0)
                                {
                                    break;
                                }

                                if (i == 0)
                                {
                                    Console.Write(arr[i]);
                                }
                                else
                                {
                                    Console.Write($", {arr[i]}");
                                }
                            }
                            Console.WriteLine("]");

                        }

                    }

                }
                command = Console.ReadLine();

                if (command == "end")
                {
                    Console.WriteLine($"[{string.Join(", ", array)}]");
                }

            }

            static int[] GetReArray(int[] array, int index)
            {                
                int[] resultArray = new int[array.Length];
                int count = 0;

                for (int i = index + 1; i < array.Length; i++)
                {
                    resultArray[count] = array[i];
                    count++;
                }

                for (int i = 0; i <= index; i++)
                {
                    resultArray[count] = array[i];
                    count++;
                }

                return resultArray;
            }

            static int GetMaxEvenOddNumber(int[] array, string evenOdd)
            {
                int backNumber = - 1;
                int max = int.MinValue;

                if (evenOdd == "even")
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] % 2 == 0 && array[i] >= max)
                        {
                            max = array[i];
                            backNumber = i;
                        }
                    }
                    return backNumber;
                }
                else if (evenOdd == "odd")
                {

                    for (int i = 0; i < array.Length; i++)
                    {

                        if (array[i] % 2 != 0 && array[i] >= max)
                        {
                            max = array[i];
                            backNumber = i;
                        }
                    }
                }
                return backNumber;

            }

            static int GetMinEvenOddNumber(int[] array, string evenOdd)
            {
                int backNumber = -1;
                int min = int.MaxValue;

                if (evenOdd == "even")
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] % 2 == 0 && array[i] <= min)
                        {
                            min = array[i];
                            backNumber = i;
                        }
                    }
                    return backNumber;
                }
                else if (evenOdd == "odd")
                {

                    for (int i = 0; i < array.Length; i++)
                    {

                        if (array[i] % 2 != 0 && array[i] <= min)
                        {
                            min = array[i];
                            backNumber = i;
                        }
                    }
                }
                return backNumber;
            }

            static int[] GetFirstCountEvenOdd(int[] array, int count, string evenOdd)
            {
                int[] result = new int[count];
                int countArr = 0;

                if (evenOdd == "even")
                {

                    for (int i = 0; i < array.Length; i++)       //even
                    {
                        if (array[i] % 2 == 0)
                        {
                            result[countArr] = array[i];
                            countArr++;
                        }
                        if (countArr == count)
                        {
                            return result;
                            break;
                        }
                    }
                }
                else if (evenOdd == "odd")
                {
                    for (int j = 0; j < array.Length; j++)       //odd
                    {
                        if (array[j] % 2 != 0)
                        {
                            result[countArr] = array[j];
                            countArr++;
                        }
                        if (countArr == count)
                        {
                            return result;
                            break;
                        }
                    }
                }
                return result;
            }

            static int[] GetLastCountEvenOdd(int[] array, int count, string evenOdd)
            {
                int[] result = new int[count];
                int countArr = 0;

                if (evenOdd == "even")
                {

                    for (int i = array.Length - 1; i >= 0; i--)       //even
                    {
                        if (array[i] % 2 == 0)
                        {
                            result[countArr] = array[i];
                            countArr++;
                        }
                        if (countArr == count)
                        {
                            return result;
                            break;
                        }
                    }
                }
                else if (evenOdd == "odd")
                {
                    for (int j = array.Length - 1; j >= 0; j--)       //odd
                    {
                        if (array[j] % 2 != 0)
                        {
                            result[countArr] = array[j];
                            countArr++;
                        }
                        if (countArr == count)
                        {
                            return result;
                            break;
                        }
                    }
                }
                return result;

            }

        }
    }
}
