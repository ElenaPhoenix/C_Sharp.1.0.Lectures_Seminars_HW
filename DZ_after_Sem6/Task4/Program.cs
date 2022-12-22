// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры). 
// Вывести на экран красивенько таблицей. Найти минимальное число и его индекс, найти максимальное число и его индекс. Вывести эту информацию на экран.
// О двухмерных массивах https://learn.microsoft.com/ru-ru/dotnet/csharp/programming-guide/arrays/multidimensional-arrays

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) //выдает строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //выдает столбцы
        {
            Console.Write(String.Format("{0,5}", $"{matrix[i, j]} "));
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) //выдает строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //выдает столбцы
        {
            matrix[i, j] = new Random().Next(1, 1000); // [1,1000)
        }
    }
    return matrix;
}

int MaxNumber(int[,] matrix)
{
    int max = matrix[0, 0];
    int row = 0;
    int column = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] > max)
            {
                max = matrix[i, j];
                row = i;
                column = j;
            }
        }
    }
    Console.WriteLine($"Максимальный элемент: {max} с индексом [{row}, {column}]");
    return max;
}

int MinNumber(int[,] matrix)
{
    int min = matrix[0, 0];
    int row = 0;
    int column = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                row = i;
                column = j;
            }
        }
    }
    Console.WriteLine($"Минимальный элемент: {min} с индексом [{row}, {column}]");
    return min;
}


Console.WriteLine($"Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
int max = MaxNumber(matrix);
int min = MinNumber(matrix);
