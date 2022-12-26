// Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // i для обозначения строк принято использовать
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-20, 21);
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j],3}\t"); // табуляция, выравнивание по правому краю, резервация места под 3 символа; если /n - каждый элемент будет начинаться с новой строчки
        Console.WriteLine();
    }
}

bool ContainsNumber(int[,] matrix, int number)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            if (matrix[i, j] == number)
            {
                Console.WriteLine($"Заданное число {number} найдено и находится под индексом [{i}, {j}]");
                return true;
            }
    Console.WriteLine($"Заданное число {number} не найдено");
    return false;
}


Console.WriteLine($"Введите количество строк двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите количество столбцов двумерного массива: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, cols];

FillMatrix(matrix);
PrintMatrix(matrix);

Console.WriteLine($"Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

ContainsNumber(matrix, number);






// int NumberSearch(int[,] matrix, int number)
// {
//     int desiredNumber = 0;
//     int row = 0;
//     int column = 0;

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (matrix[i, j] == number)
//             {
//                 desiredNumber = number;
//                 row = i;
//                 column = j;
//             }
//         }
//         Console.WriteLine($"Заданное число {desiredNumber} найдено и находится под индексом [{row}, {column}]");
//     else Console.WriteLine($"Заданное число {number} не найдено");
//     }

//     return desiredNumber;
// }
