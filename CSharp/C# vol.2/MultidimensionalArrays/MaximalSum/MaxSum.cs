/* Problem 2. Maximal sum

Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.*/

using System;

class MaxSum
{
    static void Main()
    {
        Console.Write("Enter the number of rows N: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of rows M: ");
        int cols = int.Parse(Console.ReadLine());

        // Allocate the matrix
        int[,] matrix = new int[rows, cols];

        for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("Array[{0},{1}] = ", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }

            int currSum = 0;
            int maxSum = 0;
            int maxX = 0;
            int maxY = 0;

            // range to check
            int x = 3;
            int y = 3;

            // Find biggest sum
            for (int i = 0; i < rows - x + 1; i++)
            {
                for (int j = 0; j < cols - y + 1; j++)
                {
                    currSum = 0;

                    // point x,y, calculate the sum in range [x,x+p,y,y+q]
                    for (int k = 0; k < x; k++)
                    {
                        for (int l = 0; l < y; l++)
                        {
                            currSum += matrix[i + k, j + l];
                        }
                    }

                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                        maxX = i;
                        maxY = j;
                    }
                }
            }

            // Display array
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Maximal sum is in window[{0},{1}-{2},{3}] in the array is: {4}", maxX, maxY, maxX + x - 1, maxY + y - 1, maxSum);
        }
    }


        //int maxSum = int.MinValue;
        //int maxRow = 0;
        //int maxCol = 0;
        //
        //for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        //{
        //    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
        //    {
        //        int sum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1] +
        //                  matrix[row, col + 2] + matrix[row + 2, col];
        //
        //        if (sum > maxSum)
        //        {
        //            maxSum = sum;
        //            maxRow = row;
        //            maxCol = col;
        //        }
        //    }
        //
        //}
        //
        //Console.WriteLine("Max sum is : {0}", maxSum);
        //Console.WriteLine("{0} {1} {2}", matrix[maxRow, maxCol], matrix[maxRow, maxCol + 1], matrix[maxRow, maxCol + 2]);
        //Console.WriteLine("{0} {1} {2}", matrix[maxRow + 1, maxCol], matrix[maxRow + 1, maxCol + 1], matrix[maxRow + 1, maxCol + 2]);

  