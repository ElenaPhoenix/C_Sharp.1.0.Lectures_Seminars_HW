Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int square = num * num;
Console.WriteLine("Квадрат введенного числа равен " + square);

// Если хотим внутри текста вставить значение переменных:
// Console.WriteLine($"Квадрат введенного числа равен {square}");

if (num > 9) // после ветвления не ставим ;
{
    Console.WriteLine("Вы ввели число больше 9");
}
else
{
    Console.WriteLine("Вы ввели число меньше 10");
}
while (num <= 25) // выводит все числа от введенного до 25
{
    Console.Write($"{num} ");
    num++;
}