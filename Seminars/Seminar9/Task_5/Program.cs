// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Введите натуральное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PrintNumbers(M, N));

int PrintNumbers(int M, int N)
{
    if (N == 0) return 1;
    return M * (PrintNumbers(M, N - 1));
}