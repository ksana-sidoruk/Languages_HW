// Задача 26 HARD Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 456 -> 3
// 0 -> 1
// 89,126 -> 5
// 0,001->4

decimal Prompt(string message)
{
    Console.WriteLine(message);
    string? value = Console.ReadLine();
    decimal result = Convert.ToDecimal(value);
    return result;
}

int CountDigits1(decimal num)
{
    int number = Convert.ToInt32(num);
    int count = 0;
    for (int i = 0; number > 0; i++)
        {
            number /=10;
            count += 1;
        }
    return count;
}

int CountDigits2(decimal num)
{
    decimal remainder = 1;
    int count = 0;
    for (int i = 0; remainder > 0; i++)
        {
            num *= 10;
            remainder = num - (decimal)Math.Floor(num);
            count += 1;
            }
    return count;
}

int DigitsAmount (decimal num)
{
    decimal numWhole = (decimal)Math.Floor(num);
    decimal numDeci = num - numWhole;
    
    int count1;
    if (numWhole == 0) 
        count1 = 1;
    else 
        count1 = CountDigits1(numWhole);
    
    int count2;
    if (numDeci > 0) 
        count2 = CountDigits2(numDeci);
    else 
        count2 = 0;

    int count = count1+count2;
    return count;
}

decimal num = Prompt("введите любое целое или дробное число");
Console.WriteLine($"количество цифр в числе {num}: {DigitsAmount(num)}");
