// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void FillMatrix(double[,] matrix)
{
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) // i для обозначения строк принято использовать
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = random.NextDouble() * 100;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // i для обозначения строк принято использовать
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write("{0,6:F1}", matrix[i, j]); // табуляция, выравнивание, резервация места под 5 символов; F1 - один знак после запятой
        Console.WriteLine();
    }
}


Console.WriteLine($"Введите количество строк двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите количество столбцов двумерного массива: ");
int cols = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[rows, cols];

FillMatrix(matrix);
PrintMatrix(matrix);