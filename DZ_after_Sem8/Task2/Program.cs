// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int InputNumbers(string input) // Возможность дать информацию юзеру при наборе текста, вместо Console.ReadLine
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 50);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j],3}"); // плотнее печать списка
        Console.WriteLine();
    }
}
int[] SumRowsMatrix(int[,] matrix) // находим сумму чисел каждой строки
{
    int[] sumRowsArray = new int[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        int temp = sum;
        sumRowsArray[i] = temp;
        Console.Write($"{temp,2} ");
    }
    Console.WriteLine();
    return sumRowsArray;
}

void MinSumRow(int[] array) // находим строку с наименьшей суммой элементов
{
    int count = 0;
    int min = array[0];
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            count = i;
        }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {count + 1}");
}

int rows = InputNumbers("Введите количество строк двумерного массива: ");
int cols = InputNumbers("Введите количество столбцов двумерного массива: ");
int[,] matrix = new int[rows, cols];

CreateMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Суммы элементов строк двумерного массива: ");
int[] sumRowsArray = SumRowsMatrix(matrix);
Console.WriteLine();
MinSumRow(sumRowsArray);