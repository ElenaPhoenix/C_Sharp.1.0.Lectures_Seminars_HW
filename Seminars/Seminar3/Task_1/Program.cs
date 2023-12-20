// Напишите программу, которая принимает на вход координаты точки (X и Y), при чем X не равен 0 и Y не равен 0,
// и выдает номер четверти плоскости, в которой находится эта точка.

// Console.WriteLine("Введите координату x, не равную 0");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y, не равную 0");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x>0 && y>0) Console.WriteLine("Это четверть №1");
// else if (x>0 && y<0) Console.WriteLine("Это четверть №4");
// else if (x<0 && y>0) Console.WriteLine("Это четверть №2");
// else if (x<0 && y<0) Console.WriteLine("Это четверть №3");
// else Console.WriteLine("Точка находится на оси");

// Вариант через функцию
try // пытается выполнить программный код
{
    Console.WriteLine("Введите координату x, не равную 0");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату y, не равную 0");
    int y = Convert.ToInt32(Console.ReadLine());
    //можем использовать функцию
    CheckKoord(x, y);
}
catch // если не получается выполнить программный код, выводится эта информация
{
    Console.WriteLine("Нужно вводить цифрами целое число");
}
// Создаем функцию, описываем ее в скобках
void CheckKoord(int x, int y) // ничего не возвращает, но что-то делает, нельзя совмещать с return
{
    if (x > 0 && y > 0) Console.WriteLine("Это четверть №1");
    else if (x > 0 && y < 0) Console.WriteLine("Это четверть №4"); // else if - оператор невозможных значений, не отператор ветвлений if else - выдает возможные значения
    else if (x < 0 && y > 0) Console.WriteLine("Это четверть №2");
    else if (x < 0 && y < 0) Console.WriteLine("Это четверть №3");
    else Console.WriteLine("Точка находится на оси");
}
