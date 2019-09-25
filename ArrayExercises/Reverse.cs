namespace ArrayExercises
{
    public class Reverse
    {
        //In this exercise it will be shown how to reverse and Array of string
        //Usage libraries is not allowed

        public static string[] ReverseArray(string[] listOfIntegers)
        {
            string[] reversedListOfIntegers = new string[listOfIntegers.Length];

            int index = 0;

            for (int i = listOfIntegers.Length -1; i >= 0; i--)
            {
                reversedListOfIntegers[index] = listOfIntegers[i];

                index++;
            }

            return reversedListOfIntegers;
        }
    }
}
