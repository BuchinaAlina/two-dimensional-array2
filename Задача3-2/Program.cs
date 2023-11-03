

using System;

class Program
{
    static void Main()
    {
        int[,] rectangularArray = {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12}
        };

        Console.WriteLine("Прямоугольный двумерный массив:");
        PrintArray(rectangularArray);

        int minRow = FindRowWithMinSum(rectangularArray);

        if (minRow != -1)
        {
            Console.WriteLine($"Строка с наименьшей суммой элементов: {minRow}");
        }
        else
        {
            Console.WriteLine("Массив пустой, не удалось найти строку.");
        }
    }

    static int FindRowWithMinSum(int[,] array)
    {
        int numRows = array.GetLength(0);
        int numCols = array.GetLength(1);

        if (numRows == 0 || numCols == 0)
        {
            return -1; // Если массив пустой
        }

        int minSum = int.MaxValue;
        int minRowIndex = -1;

        for (int i = 0; i < numRows; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < numCols; j++)
            {
                rowSum += array[i, j];
            }

            if (rowSum < minSum)
            {
                minSum = rowSum;
                minRowIndex = i;
            }
        }

        return minRowIndex;
    }

    static void PrintArray(int[,] array)
    {
        int numRows = array.GetLength(0);
        int numCols = array.GetLength(1);

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
