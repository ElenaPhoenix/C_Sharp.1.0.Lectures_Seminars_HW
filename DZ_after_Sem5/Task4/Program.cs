// Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, среднее арифметическое всех элементов. 
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. Найти медианное значение первоначалального массива , возможно придется кое-что для этого дополнительно выполнить.
int[] CreateArrayOfRandomNumbers(int size)  // принимает размер массива и возвращает сгенерированный массив случайных вещественных чисел
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
int[] FindMaxMinAverage(int[] array) // поиск максимального и минимального элементов массива
{
    int min = 0;
    int max = 0;
    int iMax = 0;
    int iMin = 0;

    for (int i = 0; i < array.Length; i++)
    {
                if (array[i] < max)
        {
            min = array[i];
            iMin = i;
            Console.WriteLine($"min = {min}");
            Console.WriteLine($"iMin = {iMin}");
        }
        if (array[i] > max)
        {
            max = array[i];
            iMax = i;
            Console.WriteLine($"max = {max}");
            Console.WriteLine($"iMax = {iMax}");
        }

    }
    Console.WriteLine("Максимальный элемент: " + iMax + " = " + max);
    Console.WriteLine("Минимальный элемент: " + iMin + " = " + min);

    int[] MMA = new int[] { max, min };
    return MMA;
}
Console.WriteLine("Задайте размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int[] Randomizer = CreateArrayOfRandomNumbers(size);
int[] FindMMA = FindMaxMinAverage(Randomizer);
