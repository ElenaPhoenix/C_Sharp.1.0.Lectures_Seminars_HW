// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] CreateArrayOfRandomNumbers(int size)  // принимает размер массива и возвращает сгенерированный массив случайных чисел 
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        int num = rand.Next(10);
        array[i] = num;
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    return array;
}
int SumOfElementsOfOddIndexes(int[] array) // поиск количества четных чисел 
{
    int size = array.Length;
    int sum = 0;

    for (int i = 0; i < size; i++)
    {
        if (i% 2 == 0)
            sum += array[i];
    }

    Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {sum}");
    return sum;
}
Console.WriteLine("Задайте размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] Randomizer = CreateArrayOfRandomNumbers(size);
int Sorting = SumOfElementsOfOddIndexes(Randomizer);

