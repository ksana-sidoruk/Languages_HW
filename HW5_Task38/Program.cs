// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

int Prompt (string message)
{
    System.Console.WriteLine(message);
    string? value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

void FillArray(int[] arr, int minNum, int maxNum)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minNum, maxNum+1);
    }
}

void PrintArray( int[] arr)
{
    foreach (var item in arr)
    {
        System.Console.Write($"{item} ");
    }
}

bool ValidateArray(int[] arr)
{
    if (arr.Length>1) 
        return true;
    else 
    {
        Console.WriteLine("введенная вами длина массива не позволяет решить задачу");
        return false;        
    }
}

int Substr(int[] arr)
{
    int max = arr[0];
    int min = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>max) max = arr[i];
        if(arr[i]<min) min = arr[i];
    }
    int result = max-min;
    return result;
}

int size = Prompt("Задайте длину массива");
int[] array = new int[size];

if (ValidateArray (array))
{
    int min = Prompt("Задайте минимальное значение для генератора случайных чисел");
    int max = Prompt("Задайте максимальное значение для генератора случайных чисел");
    FillArray(array, min, max);
    PrintArray(array);
    Console.WriteLine();
    Console.WriteLine($"Разница между максимальным и минимальным значением массива составляет: {Substr(array)}");
}

