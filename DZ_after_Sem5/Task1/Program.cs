// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] CreateArrayOfRandomUniqueNumbers(int size)  // принимает размер массива и возвращает сгенерированный массив случайных уникальных чисел до 1000
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        var num = rand.Next(100, 110);

        for (int j = 0; array.Contains(num); j++)
        {
            num = rand.Next(100, 110);
        }


        array[i] = num;
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    return array;
}
int[] SortingOfNumbers(int[] array) // сортировка массива от большего к меньшему и возвращает массив 
{
    int size = array.Length;
    for (int i = 0; i < size - 1; i++)
        for (int j = i + 1; j < size; j++)
            if (array[i] < array[j])
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
    foreach (int value in array) Console.Write(value + " ");
    Console.WriteLine();
    return array;
}

Console.WriteLine("Задайте размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] Randomizer = CreateArrayOfRandomUniqueNumbers(size);
int[] Sorting = SortingOfNumbers(Randomizer);
Console.WriteLine(Sorting);
