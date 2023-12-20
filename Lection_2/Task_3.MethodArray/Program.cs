int[] array = { 1, 12, 31, 4, 15, 4, 17, 18 };

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // - нашли искомое число и перестали искать, чтобы не выводить все индексы с одинаковым значением
    }
    index++; // - то же index = index+1;
}