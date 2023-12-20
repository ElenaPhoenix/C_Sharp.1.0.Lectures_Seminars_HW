// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10
// https://proglib.io/p/10-samyh-populyarnyh-algoritmov-sortirovki-na-c-2019-11-14 - О разных сортировках

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
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[] CreateArray(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            array[k] = matrix[i, j];
            k++;
        }
    }
    return array;
}

int[] BubbleSort(int[] array)
{
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
        for (int j = 0; j < array.Length - 1; j++)
            if (array[j] > array[j + 1])
            {
                temp = array[j + 1];
                array[j + 1] = array[j];
                array[j] = temp;
            }
    Console.WriteLine("Отсортированный массив:");
    foreach (int value in array) Console.Write($"{value} ");
    Console.WriteLine();
    return array;
}

int[,] ToMatrix(int[] array, int rows)

{
    var cols = array.Length / rows;
    var SortedMatrix = new int[rows, cols];
    for (var i = 0; i < array.Length; i++)
    {
        SortedMatrix[i / cols, i % cols] = array[i];
    }
    return SortedMatrix;
}


int rows = InputNumbers("Введите количество строк двумерного массива: ");
int cols = InputNumbers("Введите количество столбцов двумерного массива: ");
int[,] matrix = new int[rows, cols];


CreateMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
int[] createdArray = CreateArray(matrix);
int[] bubbleS = BubbleSort(createdArray);
Console.WriteLine();
int[,] SortedMatrix = ToMatrix(bubbleS, rows);
Console.WriteLine("Новая матрица имеет вид: ");
PrintMatrix(SortedMatrix);

