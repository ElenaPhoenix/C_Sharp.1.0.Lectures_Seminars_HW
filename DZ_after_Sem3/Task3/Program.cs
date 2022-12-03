// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.WriteLine("Введите первое число");
int num = Convert.ToInt32(Console.ReadLine());
for (int ind = 1; ind <= num; ind++)
{
    Console.Write($"{ind * ind * ind} ");
}
Console.WriteLine();
