/* Problem 4. Maximal sequence

Write a program that finds the maximal sequence of equal elements in an array. */


    using System;
    using System.Linq;
    namespace MaxlSequence
{
    class EqualElements
    {
        class MaxlSequence
        {
            static int bestLength = 0, bestElement = 0;
            static void Main()
            {
                Console.WriteLine("Enter integers separated by a comma: ");
                int[] numbers = Console.ReadLine()
                    .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x))
                    .ToArray();

                if (numbers.Length < 1)
                    return;

                var result = GetResult(numbers);
                Console.WriteLine(string.Join(", ", result));
            }

            private static int[] GetResult(int[] numbers)
            {
                int bestInt = numbers[0];
                int maxLength = 0;
                int tempLength = 1;
                int lastInt = numbers[0];

                for (int number = 1; number < numbers.Length; number++)
                {
                    if (numbers[number] != lastInt)
                    {
                        tempLength = 1;
                        lastInt = numbers[number];
                    }
                    else
                    {
                        ++tempLength;
                    }

                    if (tempLength > maxLength)
                    {
                        maxLength = tempLength;
                        bestInt = numbers[number];
                    }
                }

                return Enumerable.Range(0, maxLength).Select(x => bestInt).ToArray();
            }
        }
    }
}
        //or
        // string input = "2, 1, 1, 2, 3, 3, 2, 2, 2, 1"; //Console.ReadLine();
        // string[] numsStr = input.Split(new char[] { ',', ' ' },
        //     StringSplitOptions.RemoveEmptyEntries);
        // int[] nums = new int[numsStr.Length];
        //
        // for (int i = 0; i < nums.Length; i++)
        // {
        //     nums[i] = int.Parse(numsStr[i]);
        // }
        //
        // int[] numbers = input
        //     .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
        //     .Select(n => int.Parse(n)).ToArray();
        //
        // int[] hardcodedNums = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
        //
        // int currentNum, maxNum = nums[0];
        // int currentCount, maxCount = 0;
        //
        // for (int i = 0; i < nums.Length; )
        // {
        //     currentNum = nums[i];
        //     currentCount = 0;
        //
        //     for (; i < nums.Length; i++)
        //     {
        //         if (currentNum != nums[i])
        //         {
        //             break;
        //         }
        //
        //         currentCount++;
        //     }
        //
        //     if (maxCount < currentCount)
        //     {
        //         maxCount = currentCount;
        //         maxNum = currentNum;
        //     }
        //
        //     for (int i = 0; i < maxCount; i++)
        //     {
        //         Console.WriteLine(maxNum);
        //         if (i != maxCount - 1)
        //         {
        //             Console.Write(", ");
        //         }
        //     }
        //
        //     Console.WriteLine();
        // }
    
