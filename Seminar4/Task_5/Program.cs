// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int a=1; 

// for (int i=1; i<=num; i++) a=a*i;
// Console.WriteLine($"{a}");

//Вариант с функцией
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 1;

PrintSqr(n);
void PrintSqr(int a)
{
    for (int i = 1; i <= a; i++)
    {
        sum = sum * i;
    }
}
Console.WriteLine(sum);


