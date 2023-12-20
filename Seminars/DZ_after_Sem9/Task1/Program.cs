// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int InputNumbers(string input) // Возможность дать информацию юзеру при наборе текста, вместо Console.ReadLine
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int SeriesOfNumbersRec(int number, int count)
{
    if (number < count) Console.WriteLine($"не доступна, так как {number} - ненатуральное число");
    if (number > count)
    {
        Console.Write(number + ", ");
        SeriesOfNumbersRec(number - 1, count);
    }
    if (number == count)
        Console.Write(number + ". ");
    return number;
}


int n = InputNumbers("Введите целое число ");
int count = 1;
Console.WriteLine($" Последовательность натуральных чисел от {n} до {count} ");
SeriesOfNumbersRec(n, count);
