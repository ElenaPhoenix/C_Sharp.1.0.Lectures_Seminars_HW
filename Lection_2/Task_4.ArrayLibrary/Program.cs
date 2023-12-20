void FillArray(int[] collection) // void -невозвратный метод (нельзя использовать return), FillArray - случайное множество
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++; // - то же index = index+1;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int ind = 0;
    while (ind < count)
    {
        Console.WriteLine(col[ind]);
        ind++;
    }
}
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //условно обозначение -1 для тех случаев, когда значение не найдено
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4); // найти первую 4 в массиве, первую, т.к. в строке 31 break
Console.WriteLine(pos);