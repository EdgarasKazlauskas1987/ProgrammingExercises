using System;

namespace ArrayExercises
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* Looking for Largest and Smallest integers in an Array */
            int[] listOfIntegers = new int[] { 5, 89, 10, 44, 33, 45, 12, 3, 99, 45, 28 };

            LargestAndSmallest.FindLargestAndSmallestNumbers(listOfIntegers);


            /* Reversing input Array of strings */
            string[] listOfStrings = new string[] { "AAAA", "BBBB", "CCCC", "DDDD", "EEEE" };

            string[] reversedListOfString = Reverse.ReverseArray(listOfStrings);

            for (int i = 0; i < reversedListOfString.Length; i++)
            {
                Console.WriteLine(reversedListOfString[i] + " ");
            }
        }
    }
}
