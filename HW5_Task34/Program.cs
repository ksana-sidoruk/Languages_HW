// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int Prompt(string message)
{
    Console.WriteLine(message);
    string? value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
}

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
}

int CountEven(int[] arr)
{
    int count = 0;
    foreach (var item in arr)
    {
        if (item%2==0) count++;
    }
    return count;
}

int length = Prompt("Введите размерность создаваемого массива");
int[] array = new int[length];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве: {CountEven(array)}");