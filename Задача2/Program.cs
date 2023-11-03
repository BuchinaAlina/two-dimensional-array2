//Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


using System;

class Program
{
    static void Main()
    {
        int[,] array = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        SwapFirstAndLastRows(array);

        Console.WriteLine("Массив после замены:");
        PrintArray(array);
    }

    static void SwapFirstAndLastRows(int[,] array)
    {
        int numRows = array.GetLength(0);

        if (numRows >= 2)
        {
            // Сохраняем первую строку во временном массиве
            int[] tempRow = new int[array.GetLength(1)];
            for (int col = 0; col < array.GetLength(1); col++)
            {
                tempRow[col] = array[0, col];
            }

            // Копируем последнюю строку в первую
            for (int col = 0; col < array.GetLength(1); col++)
            {
                array[0, col] = array[numRows - 1, col];
            }

            // Копируем временную строку в последнюю
            for (int col = 0; col < array.GetLength(1); col++)
            {
                array[numRows - 1, col] = tempRow[col];
            }
        }
    }

    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
