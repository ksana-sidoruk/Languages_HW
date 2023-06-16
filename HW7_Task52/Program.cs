// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

string Average(int[,] matrix)
{
    
    string result = string.Empty;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double average = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
           average += (double)matrix[j,i]/matrix.GetLength(0); 
        }
        result += ($"среднее арифметическое столбца {1+i}: {average} \n");
    }
    return result;
}

int rows = Prompt("Введите количество строк массива");
int columns = Prompt("Введите количество столбцов массива");
int[,] array = new int[rows, columns];
int min = Prompt("Задайте минимальное значение для генератора случайных чисел");
int max = Prompt("Задайте максимальное значение для генератора случайных чисел");
FillMatrix(array, min, max);
PrintMatrix(array);
Console.WriteLine(Average(array));