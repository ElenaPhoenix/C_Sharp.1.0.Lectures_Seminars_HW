// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной (слева-сверху вправо-вниз) диагонали: 1+9+2 = 12
// Рассматриваем только квадратные массивы. Потом надо найти сумму элементов обратной диагонали (слева-снизу справа-вверх).

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-20, 21);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}\t");
        Console.WriteLine();
    }
}

void DiagonalSumArray(int[,] array)
{
    int res = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (i == j)
            {
                res += array[i, j];
            }
    Console.WriteLine($"Сумма элементов главной диагонали = {res}");
}

void Reverse(int[,] array)
{
    int res2 = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = array.GetLength(1) - 1; j >= 0; j--)
        {
            res2 = res2 + array[i, j];
            i++;
        }
    }
    Console.WriteLine($"Сумма элементов обратной диагонали = {res2}");
}

// int SumDiag(int[,] array) - нахождение обратной диагонали меньшим количеством операций
// {
//     int sum = 0;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         sum += array[i, array.GetLength(1) - i - 1];
//     }
//     return sum;
// }



// void SummaArray(int[,] array) - нахождение обеих диагоналей
// {
//     int summa = 0;
//     int summa1 = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == j)
//                 summa += array[i, j];

//             if ((array.GetLength(0) - i-1) == (j))
//                 summa1 += array[i, j];
//         }
//     Console.WriteLine($"Сумма элементов главной диагонали {summa }");
//     Console.WriteLine($"Сумма элементов обратной диагонали {summa1}");
// }

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];

FillArray(array);
PrintArray(array);
DiagonalSumArray(array);
Reverse(array);

