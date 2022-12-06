// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. 
//Сначала задается N с клавиатуры, потом задаются координаты точек.
Console.WriteLine("Введите N-мерное пространство числом больше 0");
int length = Int32.Parse(Console.ReadLine());// длина массива (N-мерное пространство)

double res = 0;
double res2 = 0;
double sum = 0;

Console.WriteLine("Введите поочередно координаты точки A");
int[] A = new int[length];//Задаем размер массива
for (int i = 0; i < length; i++)//Присваиваем значение каждой ячейки массива
{
    int k = Int32.Parse(Console.ReadLine());
    A[i] = (k);

}
Console.WriteLine("Введите поочередно координаты точки B");
int[] B = new int[length];//Задаем размер массива
for (int i2 = 0; i2 < length; i2++)//Присваиваем значение каждой ячейки массива
{
    int k = Int32.Parse(Console.ReadLine());
    B[i2] = k;
}

for (int ind = 0; ind < length; ind++)
{
    res = Math.Pow(B[ind] - A[ind], 2); //расстояние для каждого отрезка пространств
    sum = sum + res; // сложение значений всех отрезков пространств
    res2 = Math.Pow(sum, 0.5);
}
Console.WriteLine($"Длина отрезка в {length}-мерном пространстве= {res2}");




// НЕ РАБОТАЕТ
// int DistanceBetweenTwoPoints(int lengthOfArrays, int A, int B)
// {
//     int length = Int32.Parse(Console.ReadLine());// длина массива (N-мерное пространство)

//     int[] firstArray = new int[length]; //Задаем размер массива
//     int[] secodArray = new int[length]; //Задаем размер массива
//     for (int i= 0; i < length; i++) //Присваиваем значение каждой ячейки массива
//     {
//         int k1 = Int32.Parse(Console.ReadLine());
//         int k2 = Int32.Parse(Console.ReadLine());
//         firstArray[i] = (k1);
//         secodArray[i] = (k2);
//     }

//     int res = 0;
//     int res2 = 0;
//     int sum = 0;
//     for (int ind = 0; ind < length; ind++)
//     {
//         res = (int)(Math.Pow(secodArray[ind] - firstArray[ind], 2)); //расстояние для каждого отрезка пространств
//         Console.WriteLine($"res= {res}"); //====================================================test
//         sum = sum + res; // сложение значений всех отрезков пространств
//         Console.WriteLine($"sum= {sum}"); // ===================================================test
//         res2 = (int)Math.Pow(sum, 0.5);
//         Console.WriteLine($"res2={res2}"); //===================================================test
//     }
//     return res2;
// }

// Console.WriteLine("Введите N-мерное пространство числом больше 0");
// int lengthOfInfinity = Int32.Parse(Console.ReadLine()); // длина массива (N-мерное пространство)
// Console.WriteLine("Введите поочередно координаты точки A");
// int firstArrayA = Int32.Parse(Console.ReadLine()); //Задаем массив
// Console.WriteLine("Введите поочередно координаты точки B");
// int secodArrayB = Int32.Parse(Console.ReadLine()); //Задаем массив


// int Infinity = DistanceBetweenTwoPoints(lengthOfInfinity, firstArrayA, secodArrayB);
// Console.WriteLine(Infinity);


