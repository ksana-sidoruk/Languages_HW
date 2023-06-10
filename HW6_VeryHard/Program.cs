// Задача VERY HARD необязательная Имеется массив случайных целых чисел. 
// Создайте массив, в который попадают числа, описывающие максимальную сплошную возрастающую последовательность. 
// Порядок элементов менять нельзя. Одно число - это не последовательность.

// Пример:
// [1, 5, 2, 3, 4, 6, 1, 7] => [1, 7] так как здесь вразброс присутствуют все числа от 1 до 7
// [1, 5, 2, 3, 4, 1, 7, 8 , 15 , 1 ] => [1, 5] так как здесь есть числа от 1 до 5 и эта последовательность длиннее чем от 7 до 8
// [1, 5, 3, 4, 1, 7, 8 , 15 , 1 ] => [3, 5] так как здесь есть числа от 3 до 5 и эта последовательность длиннее чем от 7 до 8

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

int[] Sequence(int[] array)
{
    int min = array[0];
    int max = array[0];
    int length = 1;
    
    for (int i = 0; i < array.Length; i++)
    {
        int currentMin = array[i];
        int currentMax = array[i];
        int currentLength = 1;
        
        bool stopSeq = false;
        while (stopSeq == false)
        {
            stopSeq = true;
            for (int j = 0; j < array.Length; j++)
            {
                if (currentMax+1 == array[j])
                {
                    currentLength++;
                    currentMax = array[j];
                    stopSeq = false;
                    break;
                }
            }
        }
        if (currentLength > length)
        { 
            length = currentLength;
            min = currentMin;
            max = currentMax;
        }    
    }     
    return new int[] {min,max, length};
}

int size = Prompt("Задайте длину массива");
int[] array = new int[size]; 
int min = Prompt("Задайте минимальное значение для генератора случайных чисел");
int max = Prompt("Задайте максимальное значение для генератора случайных чисел");
FillArray(array, min, max);
PrintArray(array);
Console.WriteLine();
int[] result = Sequence(array);
if (result[2]<=1)
{
    Console.WriteLine("Числа, входящие в массив, не формируют сплошную возрастающую последовательность");
} 
else Console.WriteLine($"[{result[0]};{result[1]}]");
