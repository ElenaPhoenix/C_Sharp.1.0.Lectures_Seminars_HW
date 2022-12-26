// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // i для обозначения строк принято использовать
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-20, 21);
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // i для обозначения строк принято использовать
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j],3}\t"); // табуляция, выравнивание по правому краю, резервация места под 3 символа; если /n - каждый элемент будет начинаться с новой строчки
        Console.WriteLine();
    }
}

void AverageColumns(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum = (sum + matrix[j, i]);
        }
        array[i] = sum / matrix.GetLength(1);
        Console.Write($"{Math.Round(array[i], 1)} ");
    }
}


Console.WriteLine($"Введите количество строк двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите количество столбцов двумерного массива: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, cols];

FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
Console.Write("Среднее арифметическое каждого столбца двумерного массива: ");
AverageColumns(matrix);
