namespace StatisticsPrinter
{
    using System;
    using System.Linq;

    public class StatisticsPrinter
    {
        /*public static void Main()
        {
            //Some code...
        }*/

        public void PrintStatistics(double[] numbers, int count)
        {
            double largestNum = double.MinValue;
            double smallestNum = double.MaxValue;
            double sum = 0;

            for (int i = 0; i < count; i++)
            {
                if (numbers[i] > largestNum)
                {
                    largestNum = numbers[i];
                }

                if (numbers[i] < smallestNum)
                {
                    smallestNum = numbers[i];
                }

                sum += numbers[i];
            }

            this.PrintMax(largestNum);
            this.PrintMin(smallestNum);

            double averageNum = sum / count;
            this.PrintAvg(averageNum);
        }

        private void PrintAvg(double averageNum)
        {
            Console.WriteLine("The Average number is : {0}", averageNum);
        }

        private void PrintMin(double smallestNum)
        {
            Console.WriteLine("The Smallest number is : {0}", smallestNum);
        }

        private void PrintMax(double largestNum)
        {
            Console.WriteLine("Largest number is : {0}", largestNum);
        }
    }
}