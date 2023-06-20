// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int Prompt(string message)
{
    Console.WriteLine(message);
    string? value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

void FillMatrix(int[,] matrix)
{
    int hgt = matrix.GetLength(0)-1; 
    int lng = matrix.GetLength(1)-1; 
    int currentNum = 1;
    int currentX = 0;
    int currentY = 0;
       
    if (hgt%2==0)
    {
        matrix[hgt/2, lng/2] = matrix.GetLength(0)*matrix.GetLength(1);
    }

    for (int col = 0; col <= matrix.GetLength(1)/2; col++)
    {

        for (int j = currentX; j < lng-currentX; j++) 
        {
            matrix[currentY, j] = currentNum;
            currentNum++;
        }
       
        for (int i = currentY; i < hgt-currentY; i++) 
        {
            matrix[i, lng-currentX] = currentNum;
            currentNum++;
        }

        for (int j = lng-currentX; j > currentX; j--) 
        {
            matrix[hgt-currentY, j] = currentNum;
            currentNum++;
        }

        for (int i = hgt-currentY; i > currentY; i--)  
        {
            matrix[i, currentX] = currentNum;
            currentNum++;
        }

        currentX++;
        currentY++;
    }
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


int rows = Prompt("Введите количество строк и столбцов массива");
int columns = rows;
int[,] array = new int[rows, columns];
FillMatrix(array);
PrintMatrix(array);