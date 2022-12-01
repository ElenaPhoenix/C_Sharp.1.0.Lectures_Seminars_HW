// Напишите программу, в которой на вход принимает число N и выдается таблица квадратов чисел до N
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

for (int ind = 1; ind <= num; ind++)
{
    Console.Write($"{ind * ind} ");
}
Console.WriteLine();


