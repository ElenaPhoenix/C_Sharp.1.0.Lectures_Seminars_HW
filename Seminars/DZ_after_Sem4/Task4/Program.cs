// Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 452 -> 3
// 82 -> 2
// 9,012 ->4

//НЕ РЕШЕНА!
Console.WriteLine($"Укажите целое число или дробное число (дробная часть отделена запятой)");
decimal num = Convert.ToDecimal(Console.ReadLine());
decimal number = Math.Abs(num);
int whole = (int)number; //целая часть числа

Console.WriteLine($"whole= {whole}");
decimal value = number - whole; // дробная часть числа
Console.WriteLine($"value= {value}");

if (value == 0) // находим количество цифр в числе для целых чисел
{
    int i = 0; int count1 = (int)number;
    while (count1 > 0)//проверка для целых чисел
    {
        count1 /= 10;
        i++;
    }
    Console.WriteLine($"{i}");
}
int ind = 0;
while (ind <= 10)
{
    value *= 10;
    ind++;
    Console.WriteLine($"value2={value}");
}

// Console.WriteLine("Enter a single number:");
// char ch = Console.ReadKey(true).KeyChar;
// if (Char.IsDigit(ch))
//     Console.WriteLine($"digit= {ch}");
// else
//     Console.WriteLine("Wrong - please try again!");


// if (Char.IsNumber(ch))
//     Console.WriteLine($"number = {ch}");
// else
//     Console.WriteLine("Wrong - please try again!");



// int length=(int)Math.Log10(num)-1;
// Console.WriteLine($"length= {length}");

