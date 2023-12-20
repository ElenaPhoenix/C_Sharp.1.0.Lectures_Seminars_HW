// Напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти (x и y).
try
{
    Console.WriteLine("Введите номер четверти");
    int num = Convert.ToInt32(Console.ReadLine());
    //можем использовать функцию
    Console.WriteLine(CheckKoord2(num));
}
catch
{
    Console.WriteLine("Нужно вводить цифрами от 1 до 4");
}
// Создаем функцию, описываем ее в скобках
string CheckKoord2(int num)
{
    string res;
    if (num == 1) res = "x>0, y>0";
    else if (num == 4) res = "x>0, y<0";
    else if (num == 2) res = "x<0, y>0";
    else if (num == 3) res = "x<0, y<0";
    else res = "Введен некорректный номер четверти";
    return res;
}



