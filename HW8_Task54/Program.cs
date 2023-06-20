// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int maxP = j;
            for (int l = j+1; l < matrix.GetLength(1); l++)
            {
                if (matrix[i, l] > matrix[i, maxP]) maxP = l;                
            }
            (matrix[i, j], matrix[i, maxP]) = (matrix[i, maxP], matrix[i, j]);
        }
    }
}

int rows = Prompt("Введите количество строк массива");
int columns = Prompt("Введите количество столбцов массива");
int[,] array = new int[rows, columns];
int min = Prompt("Задайте минимальное значение для генератора случайных чисел");
int max = Prompt("Задайте максимальное значение для генератора случайных чисел");
FillMatrix(array, min, max);
PrintMatrix(array);
System.Console.WriteLine();
SortArray(array);
PrintMatrix(array);