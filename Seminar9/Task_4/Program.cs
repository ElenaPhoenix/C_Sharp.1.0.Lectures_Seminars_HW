// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PrintNumbers(M));

int PrintNumbers(int M)
{
    if (M == 0) return 0;
    else return M % 10 + (PrintNumbers(M / 10));
}