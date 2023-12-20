// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int SumOfDigits = SumOfDigitsOfNumber(num);
Console.WriteLine($"Сумма цифр в числе = {SumOfDigits}");

int SumOfDigitsOfNumber(int num)
{
    int numbers = Math.Abs(num);
    int digits = (int)Math.Log10(numbers) + 1;// находит количество цифр в числе
    int sum = 0;
    for (int index = 1; index <= digits; index++)
    {
        sum = sum + numbers % 10;
        numbers = numbers / 10;
    }
    return sum;
}