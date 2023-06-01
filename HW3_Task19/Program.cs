// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string message)
{
    Console.WriteLine(message);
    string? value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool Validate5Num(int number)
{
    if (number < 100000 && number > 9999) 
    {
        return true;
    }    
    else
    {
        Console.WriteLine ("вы написали число, не соответствующее критериям");
        return false;
    }
}

bool Palindrom(int num5)
{
    if (num5 / 10000 == num5 % 10 && num5 / 1000 % 10 == num5 / 10 % 10) return true;
    return false;
}

int num = Prompt("пожалуйста, введите целое неотрицательное пятизначное число и я определю, является ли оно палиндромом");
if (Validate5Num(num))
{
    if (Palindrom(num)) Console.WriteLine($"{num} - палиндром");
    else Console.WriteLine($"{num} - не палиндром");
}

