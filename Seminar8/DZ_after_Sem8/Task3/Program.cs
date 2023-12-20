// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// https://vscode.ru/prog-lessons/algoritm-umnozheniya-matrits.html
// https://tumovsky.by/notes/csharp-class-matrix , https://translated.turbopages.org/proxy_u/en-ru.ru.3c6a1746-63aaa03a-d2644d4f-74722d776562/https/stackoverflow.com/questions/6311309/how-can-i-multiply-two-matrices-in-c операции с матрицами подробнее

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
            matrix[i, j] = new Random().Next(0, 20);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j],5}");
        Console.WriteLine();
    }
}

int[,] MultiMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrix3;
}



try
{
    int rows1 = InputNumbers("Введите количество строк первого двумерного массива: ");
    int cols1 = InputNumbers("Введите количество столбцов первого двумерного массива: ");

    int rows2 = InputNumbers("Введите количество строк второго двумерного массива: ");
    int cols2 = InputNumbers("Введите количество столбцов второго двумерного массива: ");

    int[,] matrix1 = new int[rows1, cols1];
    CreateMatrix(matrix1);
    Console.WriteLine();
    int[,] matrix2 = new int[rows2, cols2];
    CreateMatrix(matrix2);

    if (cols1 != rows2) Console.WriteLine("Число столбцов первого двумерного массива не совпадает с числом строк второго двумерного массива. Попробуйте заново.");
    else
    {
        PrintMatrix(matrix1);
        Console.WriteLine();
        PrintMatrix(matrix2);
        Console.WriteLine();
        Console.WriteLine("Произведение двух матриц имеет вид: ");
        int[,] multiM = MultiMatrix(matrix1, matrix2);
        PrintMatrix(multiM);
    }
}

catch
{
    Console.WriteLine("Ошибка. Попробуйте снова. Помните, что количество столбцов первого массива должно быть равно количеству строк второго массива.");
}

