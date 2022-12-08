// Задайте массив случайных вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
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
void FindCountBetweenMaxMin(double[] array) // поиск разницы между максимальным и минимальным элементами массива
{
    double min = 1;
    double max = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    Console.WriteLine($"Максимальный элемент: {max}, минимальный элемент: {min}");
    Console.WriteLine($"Разница между максимальным и минимальным элементом: {max - min}");
}
Console.WriteLine("Задайте размер массива");
int size = Convert.ToInt32(Console.ReadLine());

double[] RandomizerDoubles = CreateArrayOfRandomDoubleNumbers(size);
FindCountBetweenMaxMin(RandomizerDoubles);
