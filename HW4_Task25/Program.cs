// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string message)
{
    Console.WriteLine(message);
    string? value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int Pow (int num, int stepen)
{
    int result = 1;
    for (int i = 0; i < stepen; i++)
        result = result * num;
    return result;
}

int number = Prompt("Пожалуйста, введите число");
int pow = Prompt("Пожалуйста, введите степень, в которую будем возводить ваше число");
Console.WriteLine($"Число {number} в {pow}-ой степени равняется {Pow(number, pow)}");