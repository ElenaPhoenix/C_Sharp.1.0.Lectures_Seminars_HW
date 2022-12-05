// Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.
Console.WriteLine("Введите поочередно 8 целых чисел");
int[] Array = new int[8];//Задаем размер массива
int length=Array.Length;
for (int ind = 0; ind < length; ind++)//Присваиваем значение каждой ячейки массива
{
    int k = Int32.Parse(Console.ReadLine());
    Array[ind] = (k);
}
Console.WriteLine(Array);