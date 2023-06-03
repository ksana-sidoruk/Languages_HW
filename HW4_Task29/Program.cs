// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] FillArray (int[] array, int number)
{
    array = new int[number];
    for (int i = 0; i<array.Length; i++)
    {
        array[i] = new Random().Next(1,101);
    }
    return array;
}

void PrintArray(int[] arr)
{
    foreach (int num in arr)
        Console.Write($"{num} ");
}

int[] arra = new int[8];
PrintArray(FillArray(arra, 8));