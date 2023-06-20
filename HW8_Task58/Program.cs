// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(minR, maxR + 1);
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j],5}");
        Console.WriteLine();
    }
}

int[,] MultiplyMatrix(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];

    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int l = 0; l < arrayB.GetLength(1); l++)
        {
            for (int j = 0; j < arrayA.GetLength(1); j++)
            {
                arrayC[i, l] += arrayA[i, j] * arrayB[j, l];
            }
        }
    }
    return arrayC;
}

int rowsA = Prompt("Введите количество строк матрицы А");
int colsA = Prompt("Введите количество столбцов матрицы А");
int[,] matrixA = new int[rowsA, colsA];
int rowsB = Prompt("Введите количество строк матрицы B");
int colsB = Prompt("Введите количество столбцов матрицы B");
int[,] matrixB = new int[rowsB, colsB];
int min = 1; // Prompt("Задайте минимальное значение для генератора случайных чисел");
int max = 5; // Prompt("Задайте максимальное значение для генератора случайных чисел");
FillMatrix(matrixA, min, max);
FillMatrix(matrixB, min, max);
PrintMatrix(matrixA);
System.Console.WriteLine();
PrintMatrix(matrixB);
System.Console.WriteLine();
if (rowsA != colsB && rowsB != colsA) System.Console.WriteLine("Эти матрицы нельзя перемножить");
else if (colsA == rowsB) PrintMatrix(MultiplyMatrix(matrixA, matrixB));
else PrintMatrix(MultiplyMatrix(matrixB, matrixA));
