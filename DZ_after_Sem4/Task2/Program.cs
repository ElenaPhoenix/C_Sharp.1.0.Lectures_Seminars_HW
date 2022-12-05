// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int numbers = Math.Abs(num);
int digits = (int)Math.Log10(numbers) + 1;// находит количество цифр в числе
Console.WriteLine(digits);//====================================================test
int sum = 0;
for (int index = 1; index <= digits; index++)
{
    sum = sum + numbers % 10;
    numbers = numbers / 10;

}


Console.WriteLine($"Сумма цифр в числе = {sum}");//===========================test
