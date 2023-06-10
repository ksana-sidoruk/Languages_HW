// Задача НЕГАФИБОНАЧЧИ. Задайте число. Составьте массив чисел НегаФибоначчи, в том числе для отрицательных индексов.
// Пример:
// для k = 9 массив будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]

void FillArray(int[] arr)
{
    arr[arr.Length/2] = 0;
    arr[arr.Length/2+1] = 1;
    arr[arr.Length/2-1] = 1;

    for (int i = arr.Length/2+2; i < arr.Length; i++)
    {
        arr[i] = (arr[i-1])+(arr[i-2]);
    }

    for (int i = 0; i < arr.Length/2-1; i ++)
    {
        arr[i] = arr[arr.Length-1-i];
        if (i%2==0) arr[i] = arr[i]*-1;
    }
}

void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}


Console.Clear();
System.Console.WriteLine("Введите количество чисел Фибоначчи, которое хотите увидеть по обе стороны от нуля");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size*2-1];
FillArray(array);
PrintArray(array);