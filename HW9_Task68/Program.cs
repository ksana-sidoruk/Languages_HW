// Задача 68: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int numM, int numN)
{
    if (numM == 0) return numN = numN + 1;
    if (numM > 0 && numN == 0) return Akkerman(numM - 1, 1);
    return Akkerman(numM - 1, Akkerman(numM, numN - 1));
}

Console.Clear();

System.Console.WriteLine("Введите целое неотрицательное число m");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите целое неотрицательное число n");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"А({m},{n}) возвращает {Akkerman(m, n)}");