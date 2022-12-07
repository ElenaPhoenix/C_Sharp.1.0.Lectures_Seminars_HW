// Напишите программу, которая на вход получает размерность массива. Далее заполняет его случайными уникальными числами и выводит на экран. 
// Далее производим сортировку массива от большего к меньшему и выводим на экран. Далее придумываем алгоритм перемешивания списка на основе случайности, 
// применяем этот алгоритм и выводим на экран результат. Встроенные методы работы со списками использовать нельзя.
int[] CreateArrayOfRandomUniqueNumbers(int size)  // принимает размер массива и возвращает сгенерированный массив случайных уникальных чисел до 1000
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        int num = rand.Next(1000);
        for (int j = 0; array.Contains(num); j++)
        {
            num = rand.Next(1000);
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
int[] RandomMixOfNumbers(int[] array) // перемешивание списка на основе случайности
{
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




// int[] CreateArray(int size)  // принимает размер массива и возвращает сгенерированный массив
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//         array[i] = new Random().Neind1t(-9, 10);
//     return array;
// }
// int[] CreateRandomArray(int minValue, int length)
// {
//     var random = new Random();
//     int[] array = new int[length];
//     for (int i = 0; i < length; ++i)
//     {
//         bool isUnique;
//         do
//         {
//             array[i] = random.Neind1t(0, minValue + length);
//             isUnique = true;
//             for (int j = 0; j < i; ++j)
//                 if (array[i] == array[j])
//                 {
//                     isUnique = false;
//                     break;
//                 }
//         } while (!isUnique);
//     }
//     return array;
// }


// !!ПОЛЕЗНО
// IEnumerable<int> GetRandomNumbers(int numValues, int maind1Val)// задаем размер массива со случайными уникальными числами
// {
//     var rand = new Random();
// var yieldedValues = new HashSet<int>();
// int counter = 0;
// while (counter <numValues)
// {
//     var r = rand.Neind1t(maind1Val);
//     if (yieldedValues.Add(r))
//     {
//         counter++;
//         yield return r;
//     }
// }
// }