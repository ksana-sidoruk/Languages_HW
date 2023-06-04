// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int Sum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(i%2==1) sum += arr[i];
    }
    return sum;
}

int size = Prompt("Задайте длину массива");
int min = Prompt("Задайте минимальное значение для генератора случайных чисел");
int max = Prompt("Задайте максимальное значение для генератора случайных чисел");

int[] array = new int[size];

FillArray(array, min, max);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях: {Sum(array)}");
