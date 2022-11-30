// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.
Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());

int ind = (int)Math.Log10(num) - 2;
if (ind < 0)
{
    Console.WriteLine("Третьей цифры заданного числа не существует");
}
else
{
    int res = (num % (int)Math.Pow(10, ind + 1) / (int)Math.Pow(10, ind));
    Console.WriteLine($"Третья цифра заданного числа - {res}");
}