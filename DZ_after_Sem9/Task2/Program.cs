// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int InputNumbers(string input) // Возможность дать информацию юзеру при наборе текста, вместо Console.ReadLine
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int SumNumbersRec(int number1, int number2)
{

    if (number1 < 1 || number2 < 1) return 0;                                          // Если m и n равно нулю
    else if (number1 == number2) return number1;                                       // Если m=n
    else if (number1 < 1) return (number2 * (number2 + 1)) / 2;                        // Если m равно нулю
    else if (number2 < 1) return (number1 * (number1 + 1)) / 2;                        // Если n равно нулю
    else if (number1 < number2) return number2 + SumNumbersRec(number1, number2 - 1);  // Если m<n
    else return number2 + SumNumbersRec(number1, number2 + 1);                         // Если m>n
}


int m = InputNumbers("Введите первое число: ");
int n = InputNumbers("Введите второе число: ");


Console.WriteLine($"Сумма натуральных элементов в промежутке от m до n = {SumNumbersRec(m, n)}");