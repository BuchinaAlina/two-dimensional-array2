//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

using System;

class Program
{
    static void Main()
    {
        int[,] rectangularArray = new int[3, 4]; // Создаем массив с 3 строками и 4 столбцами

        // Заполняем массив значениями
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                rectangularArray[i, j] = i * 4 + j + 1; // Пример заполнения значениями
            }
        }

        // Выводим массив на экран
        Console.WriteLine("Прямоугольный двумерный массив:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(rectangularArray[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
