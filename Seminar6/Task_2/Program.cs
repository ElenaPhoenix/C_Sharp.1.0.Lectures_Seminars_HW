// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Console.WriteLine("Введите три целых числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if (IsTriangle(a, b, c)) Console.WriteLine("Треугольник существует!");
else Console.WriteLine("Треугольник не существует!");

bool IsTriangle(int a, int b, int c)
{
    if ((a < b + c) && (b < a + c) && (c < a + b)) return true;
    else return false;
}




// Console.WriteLine("Введите первое число");
// int numA = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число");
// int numB = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите третье число");
// int numC = Convert.ToInt32(Console.ReadLine());

// int max = 0;
// if (numA > numB)
// {
//     max = numA;
// }
// else max = numB;

// if (numC > max)
// {
//     max = numC;
// }

// bool check = false;
// if (max < numA + numB + numC - max)
// {
//     check = true;
// }
// if (check) //check==true
// {
//     Console.WriteLine("Да, такой треугольник существует");
// }
// else Console.WriteLine("Нет, такой треугольник не существует");