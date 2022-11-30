// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.
Console.WriteLine("Enter an integer number");
int number = Convert.ToInt32(Console.ReadLine());
int d = 0, k = 0;
if (number > 99 && number <1000) 

{
    k = number;
    while (k >= 100)
    {
        k /= 10;
        d = k % 10;
    }
    Console.WriteLine($"The 2nd number from the left is {d}");
}
else
{
    Console.WriteLine($"There is not any 3-digits numbers, sorry");
}
