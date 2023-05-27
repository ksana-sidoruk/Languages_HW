// Задача необязательная 1: на входе целое или вещественное число, надо удалить вторую цифру слева этого числа (из целой части).

// 145 -> 15
// 1 -> нет
// 567,123 -> 57,123


Console.WriteLine("введите любое целое или вещественное положительное число");
decimal n = Convert.ToDecimal(Console.ReadLine());

if (n < 10)
{
    Console.WriteLine("в целой части этого числа нет второй цифры");
    return;
}

decimal ost = n - Math.Floor(n);
decimal n1 = Math.Floor(n);
double result = Decimal.ToDouble(n1);
int d = (int)Math.Log(result,10);
double stepen;

if (d == 1)
    stepen = 1;
else
{
    stepen = Math.Pow(10,(d-1));
}

if (n1 >= 100)
{
    double ost2 = (double)n1%stepen;
    int n2 = (int)n1 / ((int)stepen * 10);
    double ost3 = (double)ost+ost2;
    Console.WriteLine($"{n2}{ost3}");
}
else
{
    int n2 = (int)n1 / ((int)stepen * 10);
    double ost3 = (double)ost+(double)n2;
    Console.WriteLine(ost3);
}