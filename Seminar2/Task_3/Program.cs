// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
Console.WriteLine("Введите первое число");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numB = Convert.ToInt32(Console.ReadLine());
int d = numB % numA;

if (numA % numB == 0)
{
    Console.WriteLine($"Число {numB} кратно {numA}");
}
else
{
    Console.WriteLine($"Число {numB} не кратно {numA}, деление от остатка {d}");
}

// Еще пример
//Console.WriteLine("Enter two numbers: ");

// int n1 = Convert.ToInt32(Console.ReadLine());
// int n2 = Convert.ToInt32(Console.ReadLine());

// if (n2%n1 == 0) Console.WriteLine("The second number is a multiple of the first.");

// else
// {
//     Console.WriteLine("The second number is NOT a multiple of the first.");
//     int r = n2%n1;
//     Console.WriteLine($"The residue  is {r}");
//  }