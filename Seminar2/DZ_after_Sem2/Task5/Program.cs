﻿// В институте биоинформатики по офису передвигается робот. Недавно студенты из группы программистов написали для него программу, по которой робот, когда заходит в комнату, 
// считает количество программистов в ней и произносит его вслух: "n программистов". Для того, чтобы это звучало правильно, для каждого n нужно использовать верное окончание слова.
// Напишите программу, считывающую с пользовательского ввода целое число n (неотрицательное), выводящее это число в консоль вместе с правильным образом изменённым словом "программист" 
// для того, чтобы робот мог нормально общаться с людьми, например: 1 программист, 2 программиста, 5 программистов.
// В комнате может быть очень много программистов. Проверьте, что ваша программа правильно обработает все случаи, как минимум до 1000 человек.

//! Доделать! Пока не получается

Console.WriteLine("Enter an integer number");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 10 == 1)
{
    Console.Write($"{number} программист");
// }
// else if (number % 3 == 0)
// {
//     Console.Write("Fizz ");
// }
// else if (number % 5 == 0)
// {
//     Console.Write("Buzz ");
}
else
{
    Console.Write($"{number} ");
}