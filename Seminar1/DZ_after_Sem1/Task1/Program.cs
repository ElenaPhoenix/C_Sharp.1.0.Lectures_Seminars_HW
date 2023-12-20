Console.WriteLine("Введите первое целое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine($"Число {numberA} является является наибольшим из введенных");
}
else if (numberB > numberA)
{
    Console.WriteLine($"Число {numberB} является является наибольшим из введенных");
}
else
{
    Console.WriteLine("Введенные числа равны!");
}
