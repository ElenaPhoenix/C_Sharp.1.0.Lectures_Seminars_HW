// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите целое число, большее 10 или меньшее -10");
int num1 = Convert.ToInt32(Console.ReadLine());
int num = Math.Abs(num1);
int count = (int)Math.Log10(num) + 1; // находит количество цифр в числе

int sum = 0;
int res = 0;
int ind = 0;
if (num > 10 && ind <= count && count <= 10) //проверка до 10-знаковых чисел включительно, не знаю на что переключить ToInt32
{
    int mun = num - sum;
    res = mun % 10;
    sum = sum + (res * mun);
}
if (num == sum)
{
    Console.WriteLine($"{sum} - палиндром");
}
else Console.WriteLine($"{num1} - не палиндром или в числе больше 10 знаков");

