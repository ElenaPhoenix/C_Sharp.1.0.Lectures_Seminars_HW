// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
int[] CreateArray(int size)  // принимает размер массива и возвращает сгенерированный массив
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(-9, 10);
    return array;
}

void PrintArray(int[] array)
{
    foreach (int el in array)   //этот цикл только для просмотра и тут нет индексов
        Console.Write($"{el} ");
    // for (int i = 0; i < array.Length; i++)
    //     Console.Write($"{array[i]} ");
    Console.WriteLine();
}

void ChangeArray(int[] arArray)
{
    for (int i = 0; i < arArray.Length; i++)
    {
        arArray[i]*=-1;
    }
}
Console.Write("Введите размерность массива ");
int size=Convert.ToInt32 (Console.ReadLine());
int[] maxArray=CreateArray(size);
PrintArray(maxArray);
ChangeArray(maxArray);
PrintArray(maxArray);


//еще вариант
// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на 
//соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
// Console.WriteLine("Введите размерность массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArray(size);
// PrintArray(array);
// Revert(array);
// PrintArray(array);

// void Revert(int[] A)
// {
//     for (int i = 0; i < A.Length; i++)
//         A[i] = -A[i];
// }

// int[] CreateArray(int size)  // принимает размер массива и возвращает сгенерированный массив
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//         array[i] = new Random().Next(-9, 10);
//     return array;
// }

// void PrintArray(int[] array)
// {
//     foreach (int el in array)   //этот цикл только для просмотра и тут нет индексов
//         Console.Write($"{el} ");
//     // for (int i = 0; i < array.Length; i++)
//     //     Console.Write($"{array[i]} ");
//     Console.WriteLine();
// }