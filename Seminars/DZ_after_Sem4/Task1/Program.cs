// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень, в которую нужно возвести число");
int degree = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"{num} в степени {degree} = {Degree(num, degree)}");

int Degree(int num, int degree)
{
    int result = 1;
    if (degree > 0)
    {
        for (int i = 1; i <= degree; ++i) // при num>0 счетчик увеличиваем
        {
            result *= num;
        }
    }
    else if (degree < 0)
    {
        for (int i = -1; i >= degree; --i) // при num<0 счетчик уменьшаем
        {
            result /= num;
        }

    }
    return result;
}