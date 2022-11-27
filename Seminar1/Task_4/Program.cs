Console.WriteLine("Введите трехзначное целое число");
int number = Convert.ToInt32(Console.ReadLine());
int LastDigit = number%10;
Console.WriteLine($"Последняя цифра введенного трехзначного числа - это {LastDigit}");
