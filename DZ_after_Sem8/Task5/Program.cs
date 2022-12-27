// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillSpirally(int[,] matrix)
{
    int number = 1;
    int i = 0;
    int j = 0;
    int size = matrix.GetLength(0);

    while (number <= size * size)
    {
        matrix[i, j] = number;
        if (i <= j + 1 && i + j < size - 1)
            ++j;
        else if (i < j && i + j >= size - 1)
            ++i;
        else if (i >= j && i + j > size - 1)
            --j;
        else
            --i;
        ++number;
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " " + "\t");
        }
        Console.WriteLine("");
    }
}


Console.WriteLine("Введите размер квадратного двумерного массива");
int size = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[size, size];
FillSpirally(matrix);
Console.WriteLine("Матрица имеет вид: ");
PrintMatrix(matrix);

