// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// https://ru.wikipedia.org/wiki/Функция_Аккермана

int InputNumbers(string input) // Возможность дать информацию юзеру при наборе текста, вместо Console.ReadLine
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int AkkermanRec(int number1, int number2)
{
    if (number1 <= 0) return number2 + 1;
    else if (number2 <= 0 && number1 > 0) return AkkermanRec(number1 - 1, 1);
    else return (AkkermanRec(number1 - 1, AkkermanRec(number1, number2 - 1)));
}


int m = InputNumbers("Введите первое число: ");
int n = InputNumbers("Введите второе число: ");
int Akkerman = AkkermanRec(m, n);
Console.WriteLine($"A({m},{n}) = {Akkerman}");
