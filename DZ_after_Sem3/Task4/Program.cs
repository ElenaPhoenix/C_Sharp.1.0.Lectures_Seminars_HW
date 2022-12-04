// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. - евклидово расстояние
// Сначала задается N с клавиатуры, потом задаются координаты точек.
try
{Console.WriteLine("Введите N-мерное пространство числом больше 0");
int length = Int32.Parse(Console.ReadLine());// длина массива (N-мерное пространство)
double Infinity=distance(A, B);
double distance (int[]A, int[]B);
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

for (int ind=0; ind < length; ind++)
{
    double res =0; res= Math.Pow(B[ind] - A[ind], 2); //расстояние для каждого отрезка пространств
    double sum=0; sum = sum + res; // сложение значений всех отрезков пространств
    double res2=0; res2 = Math.Pow(sum, 0.5);
    Console.WriteLine($"Расстояние двух точек в N-мерном пространстве = {res2}");
}
}
catch
{
    Console.WriteLine("Данные введены некорректно. Используйте только арабские цифры");
}
