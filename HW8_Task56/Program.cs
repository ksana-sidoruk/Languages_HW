// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int Prompt(string message)
{
    Console.WriteLine(message);
    string? value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

void FillMatrix(int[,] matrix, int minR, int maxR)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minR, maxR + 1);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }
}

int GetRowNumberWithMinSum(int[,] matrix)
{
    int minRowNumber = 0;
    int minRowSum = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowSum += matrix[i, j];
        }
        if (rowSum < minRowSum || i == 0)
        {
            minRowNumber = i + 1;
            minRowSum = rowSum;
        }
    }
    return minRowNumber;
}

int rows = Prompt("Введите количество строк массива");
int columns = Prompt("Введите количество столбцов массива");
int[,] array = new int[rows, columns];
int min = Prompt("Задайте минимальное значение для генератора случайных чисел");
int max = Prompt("Задайте максимальное значение для генератора случайных чисел");
FillMatrix(array, min, max);
PrintMatrix(array);
Console.WriteLine();
Console.WriteLine($"{GetRowNumberWithMinSum(array)} - строка с наименьшей суммой элементов");