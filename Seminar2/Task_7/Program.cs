// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
if (a * a == b || b * b == a) Console.WriteLine("Да");
else Console.WriteLine("Нет");


// || - условие или 
// & - еще и...

// еще вариант
// Console.WriteLine("Enter two numbers: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());

// if (a * a == b)
// {
// 	Console.WriteLine("является");
// }
// else if (b * b == a)
// {
//     Console.WriteLine("Является");
// }
// else
// {
//     Console.WriteLine("нет");
// }
