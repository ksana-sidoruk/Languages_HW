// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

bool FindInt(int[,] matrix, int num)
{
    string message = string.Empty;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == num)
            {
                message += $"[{i}, {j}] ";
            }
        }
    }
    if (message != string.Empty)
    {
        Console.WriteLine($"позиция(позиции) найденного элемента в массиве:{message}");
        return true;
    }
    else
    {
        Console.WriteLine("В массиве такой элемент отсутствует");
        return false;
    }
}

int rows = Prompt("Введите количество строк массива");
int columns = Prompt("Введите количество столбцов массива");
int[,] array = new int[rows, columns];
int min = Prompt("Задайте минимальное значение для генератора случайных чисел");
int max = Prompt("Задайте максимальное значение для генератора случайных чисел");
int number = Prompt("Введите число, целое число которое будем искать");
FillMatrix(array, min, max);
PrintMatrix(array);
FindInt(array, number);