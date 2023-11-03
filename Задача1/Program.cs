//Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

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

        Console.WriteLine("Введите координаты элемента (строка и столбец):");
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());

        int result = GetElementAtPosition(array, row, col);

        if (result != -1)
        {
            Console.WriteLine($"Значение элемента в позиции ({row}, {col}) равно {result}");
        }
        else
        {
            Console.WriteLine($"Элемент в позиции ({row}, {col}) не существует.");
        }
    }

    static int GetElementAtPosition(int[,] array, int row, int col)
    {
        int numRows = array.GetLength(0);
        int numCols = array.GetLength(1);

        if (row >= 0 && row < numRows && col >= 0 && col < numCols)
        {
            return array[row, col];
        }

        return -1; // Элемент не существует
    }
}
