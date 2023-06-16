// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. 
// Отсортировать элементы по возрастанию слева направо и сверху вниз.


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

void SortArray(int[] arr) 
{
    for (int i = 0; i < arr.Length; i++)
    {
        int minP = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[minP]) minP = j;
        }
        (arr[i], arr[minP]) = (arr[minP],arr[i]);
    }
}

void SortMatrix(int[,] matrix)
{
    int[]array = new int[matrix.GetLength(0)*matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[j+i*matrix.GetLength(1)] = matrix[i,j];
        }
    }
    SortArray(array);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = array[j+i*matrix.GetLength(1)];
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
SortMatrix(array);
PrintMatrix(array);