// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string message)
{
    Console.WriteLine(message);
    string? value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool ValidateNum(int num)
{
    if (num == 0)
    {
        System.Console.WriteLine("сумма цифр в числе равна нулю");
        return false;
    }
    else
        return true;
}
int[] PromptArray(int number)
{
    int num = (int)Math.Abs(number);
    int[] array = new int[(int)Math.Log10(num)+1]; 
    for (int i = 0; i<array.Length; i++)
    {
        array[i] = num % 10;
        num /=10;
    }
    // Console.WriteLine(string.Join(" ",array));
    return array;
}

int Sum(int[] arr)
{
    int sum = 0;
    foreach(int number in arr)
        sum += number;
    return sum;
}

int numb = Prompt("Введите ваше целое число");
if (ValidateNum(numb))
{
    Console.WriteLine(Sum(PromptArray(numb)));
}
