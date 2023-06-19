// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string GetNumbers(int number)
{
    if (number == 1) return $"{number} ";
    return number + " " + GetNumbers(number - 1) + " ";
}

Console.Clear();

Console.WriteLine("Введите число N");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetNumbers(numN));