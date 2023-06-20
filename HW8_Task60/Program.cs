// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void FillQubik (int[,,] qube, int min, int max)
{
    Random random = new Random();
    max = max+1;

    int[] uniqueValues = new int[max-min];
    for (int i = 0; i < uniqueValues.Length; i++)
        uniqueValues[i] = min + i;
    
    for (int h = 0; h < qube.GetLength(0); h++)
    {
        for (int l = 0; l < qube.GetLength(1); l++)
        {
            for (int d = 0; d < qube.GetLength(2); d++)
            {               
                int number = random.Next(min, max);
                qube[h, l, d] = uniqueValues[number];
                uniqueValues[number] = uniqueValues[max-1];
                max--;
            }
        }
    }
}


void PrintQubic(int[,,] qube)
{
    for (int h = 0; h < qube.GetLength(0); h++)
    {
        for (int l = 0; l < qube.GetLength(1); l++)
        {
            for (int d = 0; d < qube.GetLength(2); d++)
                System.Console.Write($"{qube[h, l, d], 3} ({h},{l},{d}) ");
                System.Console.WriteLine();
        }
    }
}

Console.WriteLine("Введите последовательно параметры трехмерного массива");
int hgt = Convert.ToInt32(Console.ReadLine());
int lng = Convert.ToInt32(Console.ReadLine());
int dpt = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите последовательно минимальное и максимальное значение для генерации случайных чисел");
int minR = Convert.ToInt32(Console.ReadLine());
int maxR = Convert.ToInt32(Console.ReadLine());
int[,,] rubic = new int [hgt, lng, dpt];
FillQubik(rubic, minR, maxR);
PrintQubic(rubic);
