// Написать программу, которая на вход принимает координаты точек и находит расстояние между ними в 2D пространстве
try
{
    Console.WriteLine("Введите координаты двух точек по осям х и y");
    int x1 = Convert.ToInt32(Console.ReadLine());
    int y1 = Convert.ToInt32(Console.ReadLine());
    int x2 = Convert.ToInt32(Console.ReadLine());
    int y2 = Convert.ToInt32(Console.ReadLine());
    double Dist = distance(x1, y1, x2, y2);
    Console.WriteLine($"Расстояние между двумя точками равно {Dist}");
}
catch
{
    Console.WriteLine("Нужно вводить цифрами поочередно координаты каждой точки");
}

double distance(int x1, int y1, int x2, int y2)
{
    double res = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
    return res;
}