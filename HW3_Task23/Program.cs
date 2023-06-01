// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

int Prompt(string message)
{
    Console.WriteLine(message);
    string? value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool ValidateNum(int num)
{
    if (num < 1) 
    {
        Console.WriteLine ("вы написали число, не соответствующее критериям");
        return false;
    }    
    else
        return true;
}

string QubeInLine(int number)
{
    int qube = 0;
    string result = String.Empty;

    for (int i = 1; i <= number; i++)
    {
        qube = (int)Math.Pow(i, 3);
        result = result + " " + qube.ToString();
    }
    return result;
}

int N = Prompt("введите, пожалуйста целое, неотрицательное число N");

if (ValidateNum(N))
{
    Console.Write($"вот таблица кубов от 1 до {N}: {QubeInLine(N)}");    
}






