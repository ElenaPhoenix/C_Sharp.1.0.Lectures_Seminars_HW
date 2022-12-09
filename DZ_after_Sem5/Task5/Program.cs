// Имеется список чисел. Создайте список, в который попадают числа, описывающие максимальную возрастающую последовательность. Порядок элементов менять нельзя.
// Одно число - это не последовательность.
// [1, 5, 2, 3, 4, 6, 1, 7] => [1, 7]
// [1, 5, 2, 3, 4, 1, 7, 8 , 15 , 1 ] => [1, 5]
// [1, 5, 3, 4, 1, 7, 8 , 15 , 1 ] => [3, 5]

//ПЕРЕДЕЛАТЬ

// int[] CreateArrayByReadline(int size)
// {
//     int[] array = new int[size];//Задаем размер массива
//     for (int i = 0; i < size; i++)//Присваиваем значение каждой ячейки массива
//     {
//         Console.WriteLine("Введите числа массива");
//         //     int num = Int32.Parse(Console.ReadLine()); // Значение задавать здесь
//         //     array[i] = num;
//         //     Console.WriteLine(array[i]);//Вывод
//         // }

//         // for (int i = 0; i < size; ++i)
//         // {
//         array[i] = int.Parse(Console.ReadLine());
//         Console.Write(array[i] + " ");
//     }
//     return array;
// }

// void IncreasingSequence(int[] array)
// {
//     // int[] foundedSequence = Input();
//     int pos = 0, bestpos = 0, bestlen = 0;
//     int len = 1;

//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         if (array[i] == array[i++])
//         {
//             len++;
//             if (len > bestlen)
//             {
//                 bestlen = len;
//                 bestpos = pos;
//             }
//         }
//         else
//         {
//             len = 1;
//             pos = i++;
//         }
//     }

//     for (int k = bestpos; k <= bestlen; k++)
//     {
//         Console.Write("{0}", array[k]);
//     }
//     Console.ReadLine();



// }


// Console.WriteLine("Введите количество чисел массива");
// int size = Int32.Parse(Console.ReadLine());//Переменная которая задает размер массива
// int[] CreatedArray=CreateArrayByReadline(size);
// IncreasingSequence(CreatedArray);