// Задача 19 - HARD необязательная
// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, 
// является ли оно палиндромом. Через строку нельзя решать само собой.


int Prompt(string message)
{
    Console.WriteLine(message);
    string? value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool ValidateNum(int num)
{
    if (num > -10 && num==0 && num < 10) // на мой взгляд цифра палиндромом не является
    {
        Console.WriteLine ($"{num} - не палиндром");
        return false;
    }    
    else
        return true;
}

int[] NumToArray (int numb)
{
    int num = (int)Math.Abs(numb);
    int d = (int)Math.Log10(num);
    int[] array = new int[d+1];
    int index = 0;
    while (num>0)
    {
        int ost = num % 10;
        // Console.WriteLine($"{ost} ");
        array[index]=ost;
        num = num/10;
        index++;
    }
// Console.WriteLine(string.Join(" ",array));
    return array;
}

bool Palindrom(int[] array)
{
    for (int i = 0; i<array.Length/2; i++)
    {
        if (array[i]!=array[array.Length-1-i])
        return false;
    }
    return true;
}

int number = Prompt("введите целое число любой разрядности");

if (ValidateNum(number))
{
    int[] arr = NumToArray(number);

    if (Palindrom(arr))
        Console.WriteLine($"{number} - палиндром");
    else
        Console.WriteLine($"{number} - не палиндром"); 
}










