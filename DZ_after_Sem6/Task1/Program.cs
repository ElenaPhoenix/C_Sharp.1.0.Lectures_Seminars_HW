// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3 - почему три??
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

Console.WriteLine($"Введите количество чисел");
int size = Convert.ToInt32(Console.ReadLine());
int[] CreateNewArray = CreateArray(size);
int sum = 0;

for (int i = 0; i < CreateNewArray.Length; i++)
{

    if (CreateNewArray[i] > 0)
    {
        sum = sum + 1;
    }

}
Console.WriteLine($"Количество чисел больше нуля = {sum}");