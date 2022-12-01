// Далее обернуть всё это в функцию, конечно же , здесь нужна функция которая красиво выводит массив через запятую, создать функцию булевого типа , которая определяет больше ли 1 чем 0 в массиве
int[] Array = newAr(8);

for (int a = 0; a < 8; a++) Console.WriteLine(Array[a]);

int[] newAr(int n)
{
    int[] Array = new int[n];
    for (int a = 0; a < n; a++) Array[a] = new Random().Next(0, 2);
    return Array;
}
string WriteAr(int[] Arr)
{
    string Stroka = "[";
    for (int index = 0; index < Arr.Length;)
}