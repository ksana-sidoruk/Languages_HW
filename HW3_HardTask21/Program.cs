// Задача 21 - HARD необязательная

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними
// в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.

// Пример для проверки: из задачи 21 A (3,6,8); B (2,1,-7), -> 15.84

int PromptInt(string message)
{
    Console.WriteLine(message);
    string? value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

double PromptDouble(string message)
{
    Console.WriteLine(message);
    string? value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}

double CoordX(double[] arr1, double[] arr2)
{
    double sum = 0;

    for (int i = 0; i<arr1.Length; i++)
    {
        double sqrt = Math.Pow(arr2[i]-arr1[i],2);
        sum = sum + sqrt;
    }    
    return Math.Sqrt(sum);
}

double[] PromptDot(int dimension, string dotName)
{
    double[] result = new double[dimension];
    for (int i = 0; i<dimension; i++)
    {
        result[i] = PromptDouble($"Введите координату {i+1} точки {dotName}");
    }
    return result;
}

int dimX = PromptInt("Укажите размерность пространства, в котором будем оперировать");
double[] dot1 = PromptDot(dimX, "A");
double[] dot2 = PromptDot(dimX, "B");
Console.WriteLine($"Расстояние между точками А и В в {dimX}-м пространстве: {CoordX(dot1, dot2)}");

