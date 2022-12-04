// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//Далее обернуть всё это в функцию, конечно же , здесь нужна функция которая красиво выводит массив через запятую, создать функцию булевого типа , которая определяет больше ли 1 чем 0 в массиве
Console.WriteLine("Введите длину массива");
int n = Convert.ToInt32(Console.ReadLine());

int[] array=CreateRandomBoolArray(n);

PrintArray(array);

if (CheckOne(array)) Console.WriteLine("В массиве больше единиц, чем нулей");
else Console.WriteLine("В массиве больше нулей, чем единиц");

void PrintArray(int[] a) // функция печати массива
{
    for (int i = 0; i < a.Length; i++) Console.Write($"{a[i]}");
    Console.WriteLine($"{a[^1]}");
}
bool CheckOne(int[] a) // функция на проверку количества единиц и нулей в массиве
{
    int sum = 0;
    for (int i = 0; i < a.Length; i++) sum = sum + a[i];

    if (sum > a.Length / 2) return true;
    else return false;
}

int[] CreateRandomBoolArray(int count) // функция генерации массива указанной длины из 1 и 0
{
    int[] array = new int[count];

    for (int i = 0; i < count; i++) array[i] = new Random().Next(0,2);
    return array;
}







// int[] Array = newAr(8);

// for (int ind = 0; ind < 8; ind++) Console.WriteLine(Array[ind]);

// int[] newAr(int n)
// {
//     int[] Array = new int[n];
//     for (int a = 0; a < n; a++) Array[a] = new Random().Next(0, 2);
//     return Array;
// }
// string WriteAr(int[] Arr)
// {
//     string Stroka = "[";
//     for (int index = 0; index < Arr.Length; index++);//???????????
// }