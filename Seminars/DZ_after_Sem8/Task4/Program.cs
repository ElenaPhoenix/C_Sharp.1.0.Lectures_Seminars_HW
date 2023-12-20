// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся (HARD - случайные уникальные) двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int InputNumbers(string input) // Возможность дать информацию юзеру при наборе текста, вместо Console.ReadLine
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int[] CreateArrayOfRandomUniqueNumbers(int size)  //Генерирует массив случайных уникальных чисел до 100
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        int num = rand.Next(10, 100);
        for (int j = 0; array.Contains(num); j++)
        {
            num = rand.Next(10, 100);
        }
        array[i] = num;
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    return array;
}

void FillPrintMatrix3D(int[,,] matrix3D, int[] array)
{
    int l = 0;
    for (int k = 0; k < matrix3D.GetLength(2); k++)
    {
        for (int i = 0; i < matrix3D.GetLength(0); i++)
        {
            Console.Write(Environment.NewLine + Environment.NewLine);
            for (int j = 0; j < matrix3D.GetLength(1); j++)
            {
                matrix3D[i, j, k] = array[l];
                l++;
                Console.Write($"{matrix3D[i, j, k]}({i},{j},{k})\t");
            }
        }
        Console.Write(Environment.NewLine + Environment.NewLine);
    }
}


int rows = InputNumbers("Введите количество строк двумерного массива: ");
int cols = InputNumbers("Введите количество столбцов двумерного массива: ");
int pages = InputNumbers("Введите количество страниц двумерного массива: ");

int[] NumbersArray = new int[rows * cols * pages];
int[] uniqueNumbersArray = CreateArrayOfRandomUniqueNumbers(NumbersArray.Length);

int[,,] matrix3D = new int[rows, cols, pages];
FillPrintMatrix3D(matrix3D, uniqueNumbersArray);
