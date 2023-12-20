
// Пока не сделано!! Не разобралась с Math**

Console.WriteLine("Enter an integer number");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99)
{
int k = Convert.ToInt32(Math.Log10(number));
int d= Convert.ToInt32(Math.Log10(k*1000));
Console.WriteLine($"The 3rd number from the left is {d}");
}
else
{
    Console.WriteLine($"The number has fewer than 3 digits, sorry");
}


// int d = 0, k = 0;
//  k = number;
//     while (k >= 1000)
//     {
//         k /= 10;
//         d = k % 10;


// int i = 0;
// int result = (number / (int)Math.Pow(10,i-1)) % 1000;
// Console.WriteLine($"The 3rd number from the left is {result}");

// Console.WriteLine("Enter an integer number");
// int number = Convert.ToInt32(Console.ReadLine());
// int i=0;
// (int)Math.Log10(i);
// Console.WriteLine($"The 3rd number from the left is {result}")
