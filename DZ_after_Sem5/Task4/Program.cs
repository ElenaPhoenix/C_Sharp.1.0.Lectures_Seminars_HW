// Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, среднее арифметическое всех элементов. 
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. Найти медианное значение первоначалального массива , возможно придется кое-что для этого дополнительно выполнить.
double[] CreateArrayOfRandomNumbers(int size)  // принимает размер массива и возвращает сгенерированный массив случайных вещественных чисел
{
    double[] array = new double[size];
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

double[] FindMaxMinAverage(double[] array) // поиск максимального и минимального элементов массива с индексами, среднего арифметического
{
    int i = 0;
    double min = array[i];
    double max = array[i];
    int iMax = 0;
    int iMin = 0;
    double count = 0;
    double average = 0;

    while (i < array.Length)
    {
        if (array[i] < min)
        {
            min = array[i];
            iMin = i;
        }
        if (array[i] > max)
        {
            max = array[i];
            iMax = i;
        }
        count = count + array[i];
        average = count / array.Length;

        i++;
    }
    Console.WriteLine("Максимальный элемент с индексом " + iMax + " = " + max);
    Console.WriteLine("Минимальный элемент с индексом " + iMin + " = " + min);
    Console.WriteLine("Среднее арифметическое = " + average);
    double[] MMA = new double[] { max, min, average };
    return MMA;
}

double[] Explanations(double[] array) // вывод найденных значений в отдельный массив с пояснениями
{
    int i = 0;
    while (i <= array.Length)
    {
        if (i == 0) Console.WriteLine("Максимальный элемент основного массива = " + array[i]);
        if (i == 1) Console.WriteLine("Минимальный элемент основного массива = " + array[i]);
        if (i == 2) Console.WriteLine("Среднее арифметическое основного массива = " + array[i]);
        i++;
    }
    return array;
}

double MedianOfArray(double[] array) // поиск медианы массива
{

    Array.Sort(array);

    double medianValue = 0;

    if (array.Length % 2 == 0) // если количество элементов четное, нужно получить два средних элемента, сложить их вместе, затем разделить на 2
    {
        double middleElement1 = array[(array.Length / 2) - 1];
        double middleElement2 = array[(array.Length / 2)];
        medianValue = (middleElement1 + middleElement2) / 2;
        Console.WriteLine("Медианное значение основного массива = " + medianValue);
    }
    else // если количество элементов четное, выводим средний элемент 
    {
        medianValue = array[(array.Length / 2)];
        Console.WriteLine("Медианное значение основного массива = " + medianValue);
    }

    return medianValue;
}

Console.WriteLine("Задайте размер массива");
int size = Convert.ToInt32(Console.ReadLine());

double[] Randomizer = CreateArrayOfRandomNumbers(size);
double[] FindMMA = FindMaxMinAverage(Randomizer);
double[] Exp = Explanations(FindMMA);
double Median=MedianOfArray(Randomizer);