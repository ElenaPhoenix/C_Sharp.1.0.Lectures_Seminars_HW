// Задайте массив случайных вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] CreateArrayOfRandomDoubleNumbers(int size)  // принимает размер массива и возвращает сгенерированный массив случайных вещественных чисел
{
    double[] array = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rand.NextDouble();
        array[i] = num;
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    return array;
}
int FindCountOfEvenNumbers(int[] array) // поиск разницы между максимальным и минимальным элементами массива
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
double[] RandomizerDoubles = CreateArrayOfRandomDoubleNumbers(size);
double[] Sorting = FindCountOfEvenNumbers(RandomizerDoubles);
