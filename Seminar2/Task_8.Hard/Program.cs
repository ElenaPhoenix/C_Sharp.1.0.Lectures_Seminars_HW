// Напишите программу, которая принимает на вход числа через цикл и проверяет находятся ли там квадраты чисел каждого к каждому. И если да, выводит какое именно число является квадратом какого.
// ДОДЕЛАТЬ
Console.WriteLine("Введите последовательность целых чисел");
int count = Convert.ToInt32(Console.ReadLine());
int[] array = new int[count];
int result = 0;

for (int i = 0; i < count; i++) array[i] = Convert.ToInt32(Console.ReadLine());

for (int j = 0; j < count - 2; j++)
{
    for (int k = j + 1; k < count - 1; k++)
    {
        if (array[j] == array[k] * array[k])
        {
            Console.WriteLine($"{array[j]} является квадратом {array[k]}");
            result++;
        }
        else
            if (array[k] == array[j] * array[j])
        {
            Console.WriteLine($"{array[k]} является квадратом {array[j]}");
            result++;
        }
    }
}
if (result == 0)
{
    Console.WriteLine("Квадратов чисел нет");
}