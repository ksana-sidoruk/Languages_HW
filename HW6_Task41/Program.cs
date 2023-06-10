// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt (string message)
{
    Console.WriteLine(message);
    string? value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int CountPositiveInts(int number)
{
    Console.WriteLine("Введите последовательно указанное вами количество чисел");
    int count = 0;
    for (int i = 0; i <= number; i++)
    {
        int userNumber = Convert.ToInt32(Console.ReadLine());
        if (userNumber > 0) count ++;
    }
        return count;
}

int numbersAmount = Prompt("Сколько чисел планируете вводить?");
Console.WriteLine($"Среди введенных вами чисел, количество тех, которые больше нуля: {CountPositiveInts(numbersAmount)}");
