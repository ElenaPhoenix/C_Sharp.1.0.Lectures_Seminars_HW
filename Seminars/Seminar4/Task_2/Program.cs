// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
int [] Array= new int [8];

for(int a=0; a<8; a++) Array[a]=new Random().Next(0,2);
for(int a=0; a<8; a++) Console.WriteLine(Array[a]);