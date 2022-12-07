// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] CreateArrayOfRandomNumbers(int size)  // принимает размер массива и возвращает сгенерированный массив случайных трехзначных чисел
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        int num = rand.Next(1000);
        array[i] = num;
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    return array;
}
int FindCountOfEvenNumbers(int[] array) // поиск количества четных чисел
{
    int count = 0;
    int size=array.Length;
    for (int i = 0; i < size-1; i++)
    
        if (array[i] % 2 == 0 && i<size-1) // проверка на чет
            count = count + 1;
    Console.WriteLine(count);
    return count;
}
Console.WriteLine("Задайте размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] Randomizer = CreateArrayOfRandomNumbers(size);
int Sorting = FindCountOfEvenNumbers(Randomizer);