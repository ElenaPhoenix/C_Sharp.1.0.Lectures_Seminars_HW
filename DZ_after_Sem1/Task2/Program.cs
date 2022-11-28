Console.WriteLine("Введите первое целое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число, отличное от первого");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число, отличное от первого и второго");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (numberB>max) 
{
    max=numberB;
}
if (numberC>max)
{
    max=numberC; 
    Console.WriteLine ($"Максимальное число найдено и равно {max}");
}
else Console.WriteLine ($"Максимальных чисел несколько, равны значению {max}");