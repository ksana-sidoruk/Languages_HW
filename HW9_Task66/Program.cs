// Задача 66: Задайте значения M и N. Н
// апишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetNumbersSumm(int numM, int numN)
{
    if (numM == numN) return numN;
    else return numM + GetNumbersSumm(numM+1,numN); 
}

Console.Clear();

System.Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(GetNumbersSumm(m, n));