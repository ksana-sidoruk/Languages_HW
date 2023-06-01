// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

double Prompt(string message)
{
    Console.WriteLine(message);
    string? value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}

double Coord3(double A1, double A2, double A3, double B1, double B2, double B3)
{
    double precalc = Math.Sqrt(Math.Pow((B1-A1),2) + Math.Pow((B2-A2),2) + Math.Pow((B3-A3),2));
    double roundedResult = Math.Round(precalc, 2);
    return roundedResult;
}

double Xa = Prompt ("введите первую координату точки А");
double Ya = Prompt ("введите вторую координату точки А");
double Za = Prompt ("введите третью координату точки А");
double Xb = Prompt ("введите первую координату точки B");
double Yb = Prompt ("введите вторую координату точки B");
double Zb = Prompt ("введите третью координату точки B");

Console.WriteLine($"расстояние между точками А и В составит {Coord3(Xa, Ya, Za, Xb, Yb, Zb)}");