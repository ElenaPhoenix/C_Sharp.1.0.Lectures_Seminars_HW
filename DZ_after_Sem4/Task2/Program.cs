// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int numbers=Math.Abs(num);
//int nDigits = log10(Abs(num)) + 1;
Console.WriteLine(numbers);

// int index = 0;
// while (num > 0) // находит количество цифр в числе
// {
//     int deg = 0; deg = num / 10;
//     index++;
    
//     for (int ind = 0; ind <= index; ind++)
//     {
//         int remainder = 0; remainder = num % 10;
//         int sum = 0; sum += remainder;
//         Console.WriteLine($"Сумму цифр в числе = {sum}");
//     }
// }


