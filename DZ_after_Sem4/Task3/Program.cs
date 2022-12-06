// Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.
int[] CreateArray(int count) // функция генерации массива указанной длины
{
    int[] array = new int[count];
    Console.WriteLine($"Введите поочередно {count} целых чисел");
    for (int i = 0; i < count; i++) //Задаем поочередно с консоли элементы массива
    {
        array[i] = (Convert.ToInt32(Console.ReadLine()));
    }
    for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} "); //Выводим все элементы массива
    return array;
}

int[] array1 = new int[8];
int[] CreateNewArray = CreateArray(8);