// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. 
// Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, 
// среднее арифметическое всех элементов. 
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. 
// Найти медианное значение первоначалального массива , 
// возможно придется кое-что для этого дополнительно выполнить.

int Prompt(string message)
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
        arr[i] = new Random().Next(minNum, maxNum + 1);
    }
}

void PrintArray(int[] arr)
{
    foreach (var item in arr)
    {
        System.Console.Write($"{item} ");
    }
}

bool ValidateArray(int[] arr)
{
    if (arr.Length > 1)
        return true;
    else
    {
        Console.WriteLine("С такой длиной массива решать задачу неинтересно. Введите число побольше!");
        return false;
    }
}

int[] Statistics(int[] arr)
{
    int[] stats = new int[5];
    int max = arr[0];
    int min = arr[0];
    int maxIndex = 0;
    int minIndex = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
            maxIndex = i;
        }
        if (arr[i] < min)
        {
            min = arr[i];
            minIndex = i;
        }
    }

    int average = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        average += arr[i] / arr.Length;
    }

    stats[0] = max;
    stats[1] = maxIndex;
    stats[2] = min;
    stats[3] = minIndex;
    stats[4] = average;
    return stats;
}

int[] SortArray(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int minP = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[minP]) minP = j;
        }
        int temp = arr[i];
        arr[i] = arr[minP];
        arr[minP] = temp;

    }
    return arr;
}

double Mediana(int[] arr)
{
    double media;
    if (arr.Length % 2 == 0)
        media = (arr[arr.Length / 2] + arr[arr.Length / 2 - 1]) / 2;
    else
        media = arr[arr.Length/2];
    return media;
}

int size = Prompt("Задайте длину массива");
int[] array = new int[size]; 

if (ValidateArray(array))
{
    int min = Prompt("Задайте минимальное значение для генератора случайных чисел");
    int max = Prompt("Задайте максимальное значение для генератора случайных чисел");
    FillArray(array, min, max);
    PrintArray(array);
    Console.WriteLine();
    Console.WriteLine($"Максимальный элемент созданного массива: {Statistics(array)[0]}, а индекс этого элемента: {Statistics(array)[1]}. \nМинимальный элемент созданного массива: {Statistics(array)[2]}, а индекс этого элемента: {Statistics(array)[3]}. \nСреднее арифметическое всех элементов массива: {Statistics(array)[4]}.");
    SortArray(array);
    PrintArray(array);
    Console.WriteLine();
    Console.WriteLine($"Выше выведен массив, отсортированный для поиска его медианного значения. Медианное значение массива: {Mediana(array)}");
}

