// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
string[] days = {"будний", "будний", "будний", "будний", "будний", "выходной!", "выходной"};
int index = 0;

Console.WriteLine("Введите цифру, обозначающую день недели и я определю, является ли он выходным");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 7 ) 
    Console.WriteLine("Вообще-то в неделе всего 7 дней");

index = day - 1;
Console.WriteLine(days[index]);


// вариант решения не через массив: 

// System.Console.WriteLine("Введите цифру, обозначающую день недели и я определю, является ли он выходным");
// int date = Convert.ToInt32(Console.ReadLine());

// if (date > 5 && date < 8) 
//     System.Console.WriteLine("Ура, выходные!");
// else if (date >= 8)
//     System.Console.WriteLine("Вообще то в неделе всего 7 дней");
// else
//     System.Console.WriteLine("Надо идти на работу");