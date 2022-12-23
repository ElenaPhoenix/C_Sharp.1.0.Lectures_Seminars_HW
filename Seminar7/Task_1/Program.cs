// Задайте двумерный массив размером m*n, заполненный случайными целыми числами.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) // i для обозначения строк принято использовать
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-20, 21);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) // i для обозначения строк принято использовать
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}\t"); // табуляция, выравнивание по правому краю, резервация места под 3 символа; если /n - каждый элемент будет начинаться с новой строчки
        Console.WriteLine();
    }
}


Console.WriteLine($"Введите количество строк двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите количество столбцов двумерного массива: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, cols];

FillArray(array);
PrintArray(array);