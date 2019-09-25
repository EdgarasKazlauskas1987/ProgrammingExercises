using System;

namespace ArrayExercises
{
    public class LargestAndSmallest
    {
        //In this exercise it will be shown how to ind a largest and a smallest integer in an Array
        //Usage of libraries is not allowed

        public static void FindLargestAndSmallestNumbers(int[] listOfIntegers)
        {
            int largest = int.MinValue;
            int smallest = int.MaxValue;

            foreach (int number in listOfIntegers)
            {
                if (number > largest)
                    largest = number;

                else if (number < smallest)
                    smallest = number;
            }

            Console.WriteLine("Largest number is: " + largest.ToString() + "\n" + "Smallest number is: " + smallest.ToString()); 
        }
    }
}
