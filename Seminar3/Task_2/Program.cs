try
{
    Console.WriteLine("Введите координату x, не равную 0");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату y, не равную 0");
    int y = Convert.ToInt32(Console.ReadLine());
    //можем использовать функцию
    Console.WriteLine(CheckKoord2(x, y));
}
catch
{
    Console.WriteLine("Нужно вводить цифрами целое число");
}
// Создаем функцию, описываем ее в скобках
string CheckKoord2(int x, int y) // функция возвращает строковое значение
{
    string res;
    if (x > 0 && y > 0) res = "Это четверть №1";
    else if (x > 0 && y < 0) res = "Это четверть №4";
    else if (x < 0 && y > 0) res = "Это четверть №2";
    else if (x < 0 && y < 0) res = "Это четверть №3";
    else res = "Точка находится на оси";
    return res;
}
