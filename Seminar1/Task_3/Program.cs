Console.WriteLine("Введите целое положительное число");
int num = Convert.ToInt32(Console.ReadLine());
int i = -num;
while (i <= num)
{
    Console.Write($"{i} ");
    i++;
}
Console.WriteLine();