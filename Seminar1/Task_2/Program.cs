Console.WriteLine("Введите первое целое число");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число, отличное от первого");
int numB = Convert.ToInt32(Console.ReadLine());


if (numA*numA==numB) // первый if - основное условие, если выполняется - дальше программа не смотрит
{
    Console.WriteLine($"Число {numB} является квадратом числа {numA}");
}
else if (numB*numB==numA)
{
    Console.WriteLine($"Число {numA} является квадратом числа {numB}");
}
else // в остальных случаях
{
    Console.WriteLine($"Квадраты чисел отсутствуют!");
}
