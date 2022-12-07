// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] CreateArrayOfRandomUniqueNumbers(int size)  // принимает размер массива и возвращает сгенерированный массив случайных уникальных чисел до 1000
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int ind1 = 0; ind1 < array.Length; ind1++)
    {
        array[ind1] = rand.Next(1000);
        Console.Write(array[ind1] + " ");
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
int[] RandomMixOfNumbers(int[] array) // перемешивание списка на основе случайности
{  //для всех i от n − 1 до 1 выполнить
   //  j ← случайное число 0 ≤ j ≤ i
   //  обменять местами a[j] и a[i]
    int size = array.Length;
    Random rand = new Random(size);

    for (int i = size - 1; i >= 0; i--)
    {
        int j = rand.Next(i + 1);
        int tmp = array[j];
        array[j] = array[i];
        array[i] = tmp;
        Console.Write(array[i] + " ");
    }
    return array;
}
Console.WriteLine("Задайте размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] Randomizer = CreateArrayOfRandomUniqueNumbers(size);
int[] Sorting = SortingOfNumbers(Randomizer);
int[] Mix = RandomMixOfNumbers(Sorting);
Console.WriteLine(Mix);
