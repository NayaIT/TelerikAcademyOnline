﻿/* Problem 1. Fill the matrix

Write a program that fills and prints a matrix of size (n, n) as shown below:
Example for n=4 */

using System;

class Matrix
{
    static void Main()
    {
        Console.Write("Please enter number for n: ");
		int n = int.Parse(Console.ReadLine());

		Console.Write("How would you want to fill the matrix (a, b, c or d): ");
		char choice = char.Parse(Console.ReadLine());

		int[,] matrix = new int[n, n];
		switch (choice)
		{
			case 'a': FillMatrixA(matrix); break;
			case 'b': FillMatrixB(matrix); break;
			case 'c': FillMatrixC(matrix); break;
			case 'd': FillMatrixD(matrix); break;

		}
		PrintingMatrix(matrix);
	}

	private static void FillMatrixA(int[,] matrix)
	{
		for (int col = 0, index = 1; col < matrix.GetLength(1); col++)
		{
			for (int row = 0; row < matrix.GetLength(0); row++, index++)
			{
				matrix[row, col] = index;
			}
		}
	}

	private static void FillMatrixB(int[,] matrix)
	{
		bool isDirDown = true;
		for (int col = 0, row = 0, index = 1; col < matrix.GetLength(1); col++)
		{
			while (row >= 0 && row < matrix.GetLength(0))
			{
				matrix[row, col] = index++;
				row += isDirDown ? +1 : -1; // Change 'row' value
			}
			// Change direction and change 'row' value
			isDirDown = !isDirDown;
			row += isDirDown ? +1 : -1;
		}
	}

	private static void FillMatrixC(int[,] matrix)
	{
		for (int row = matrix.GetLength(0) - 1, index = 1; index <= matrix.GetLength(0) * matrix.GetLength(1); row--)
		{
			for (int currCol = (row >= 0 ? 0 : -row), currRow = (row >= 0 ? row : 0);
				currCol < (matrix.GetLength(1) - (row >= 0 ? row : 0));)
			{
				matrix[currRow++, currCol++] = index++;
			}
		}
	}

	private static void FillMatrixD(int[,] matrix)
	{
		string direction = "down";
		int row = -1, col = 0;

		for (int index = 1; index <= matrix.GetLength(0) * matrix.GetLength(1); index++)
		{
			if (direction == "down")
			{
				if (matrix[++row, col] == 0) matrix[row, col] = index;
				if (!IsTraversable(matrix, row + 1, col)) direction = "right";
			}
			else if (direction == "right")
			{
				if (matrix[row, ++col] == 0) matrix[row, col] = index;
				if (!IsTraversable(matrix, row, col + 1)) direction = "up";
			}
			else if (direction == "up")
			{
				if (matrix[--row, col] == 0) matrix[row, col] = index;
				if (!IsTraversable(matrix, row - 1, col)) direction = "left";
			}
			else if (direction == "left")
			{
				if (matrix[row, --col] == 0) matrix[row, col] = index;
				if (!IsTraversable(matrix, row, col - 1)) direction = "down";
			}
		}
	}

	static bool IsTraversable(int[,] matrix, int row, int col)
	{
		return row >= 0 && row < matrix.GetLongLength(0) &&
			   col >= 0 && col < matrix.GetLongLength(1) && matrix[row, col] == 0;
	}

	private static void PrintingMatrix(int[,] matrix)
	{
		for (int row = 0; row < matrix.GetLength(0); row++)
		{
			for (int col = 0; col < matrix.GetLength(1); col++)
			{
				Console.Write(matrix[row, col] + "\t");
			}
			Console.WriteLine();
		}
	}
}
        //int[,] spiral = new int[4, 4];
        //int counter = 1;
        //
        //for (int col = 0; col < 4; col++)
        //{
        //    for (int row = 0; row < 4; row++)
        //    {
        //        spiral[row, col] = counter;
        //        counter++;
        //    }
        //}
        //
        //Console.WriteLine(" " + counter);
    