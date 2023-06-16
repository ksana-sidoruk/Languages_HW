// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int Prompt(string message)
{
    Console.WriteLine(message);
    string? value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

void FillMatrix (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            Random x = new Random();
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] = Convert.ToDouble(x.Next(-100, 100)/10.0);
            }
        }           
}

void PrintMatrix (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j],4}    "); 
        System.Console.WriteLine();
        }
}

int rows = Prompt ("Введите ваше m");
int columns = Prompt ("Введите ваше n");
double[,] matrix = new double[rows,columns];
FillMatrix(matrix);
PrintMatrix(matrix);