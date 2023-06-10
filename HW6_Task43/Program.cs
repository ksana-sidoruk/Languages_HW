// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double[] DotCoordinate (double a, double c, double b, double d)
{
    double x;
    double y;
    x = (d-c)/(a-b);
    y = a*x+c;
    
    double[] coord = new double[] {x, y};
    return coord;
}

Console.WriteLine("Введите последовательно k1, b1, k2, b2");
double k1 = Convert.ToDouble(Console.ReadLine());
double b1 = Convert.ToDouble(Console.ReadLine());
double k2 = Convert.ToDouble(Console.ReadLine());
double b2 = Convert.ToDouble(Console.ReadLine());

if (k1==k2 && b1!=b2) 
    Console.WriteLine("прямые не имеют точки пересечения");
else if (k1==k2 && b1==b2) 
    Console.WriteLine("прямые совпадают");
else 
    Console.WriteLine($"Координаты точки пересечения прямых ({DotCoordinate (k1, b1, k2, b2)[0]}; {DotCoordinate (k1, b1, k2, b2)[1]})");
