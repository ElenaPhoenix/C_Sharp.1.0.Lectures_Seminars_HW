// Напишите программу, которая выводит на экран числа от 1 до 100. При этом вместо чисел, кратных трем, программа должна выводить слово Fizz, 
// а вместо чисел, кратных пяти — слово Buzz. Если число кратно пятнадцати, то программа должна выводить слово FizzBuzz. Задача может показаться очевидной, но нужно получить наиболее простое и красивое решение.
int[] Array=new int[101];
string ind1=Fizz;

for (int numbers=1; numbers<Array.Length;numbers++)  //+
{
    Console.Write(numbers+" ");
    ind1 = ind1.Replace(Array[0]*3, "Fizz");
    // for(int i2=1; i2<Array.Length; i2=i2*5) ind2 = ind2.Replace(i2, "Buzz");
    // for(int i3=1; i3<Array.Length; i3=i3*15) ind3 = ind3.Replace(i3, "FizzBuzz");
    
}
// string Array(int count, string text)
// {

// }














