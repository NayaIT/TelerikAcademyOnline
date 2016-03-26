namespace DecreasingAbsoluteDifference
{
    using System;

    public class DecreasingAbsoluteDifference
    {
        public static void Main()
        {
            var numberOfSequences = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfSequences; i++)
            {
                var line = Console.ReadLine();
                var numbersAsString = line.Split(' ');
                var numbers = new long[numbersAsString.Length];
                for (int j = 0; j < numbersAsString.Length; j++)
                {
                    numbers[j] = int.Parse(numbersAsString[j]);
                }

                var result = IsDecreasing(numbers);
                Console.WriteLine(result);
            }
        }

        private static bool IsDecreasing(long[] numbers)
        {
            if (numbers.Length <= 2)
            {
                return true;
            }

            long absoluteDifferences = Math.Abs(numbers[1] - numbers[0]);
            for (int i = 2; i < numbers.Length; i++)
            {
                long diff = Math.Abs(numbers[i] - numbers[i - 1]);
                if (absoluteDifferences - diff != 1 && absoluteDifferences - diff != 0)
                {
                    return false;
                }

                absoluteDifferences = diff;
            }

            return true;
        }
    }
}