//  На вход программы подаются одно целое число. Составьте список чисел Фибоначчи, в том числе для отрицательных индексов. Это по сути последовательность Негафибоначчи.
// для k = 8 список будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]
//  https://ru.wikipedia.org/wiki/Негафибоначчи
// Варинанты вычислений https://ru.wikibooks.org/wiki/Вычисление_чисел_Фибоначчи

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2) - фибоначчи
//F(n)=F(n+2)-F(n+1) - негафибоначчи

//ДОДЕЛАТЬ

int NegaFibonacci(int number)
{
    for (int j = number; j <= -1; j++)
        if (number == -1)
        {
            return 1;
            Console.Write(NegaFibonacci(j) + ",");
        }
        else if (number == -2)
        {
            return -1;
            Console.Write(NegaFibonacci(j) + ",");
        }
        else
        {
            return NegaFibonacci(number + 2) - NegaFibonacci(number + 1);
            Console.Write(NegaFibonacci(j) + ",");
        }

}



// int Fibonacci(int number)
// {
//     if (i == 1 || i == 2) return 1;
//     else return Fibonacci(i - 1) + Fibonacci(i - 2);
// }



Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int NegaFib = NegaFibonacci(number);
//NegaFibPrint(NegaFib);
Console.WriteLine($"{NegaFib}");
// int Fib = Fibonacci(number);
// Console.Write(Fibonacci(number) + ",");


// int[] CreateFibonacciArr(int number)  // принимает размер массива и возвращает сгенерированный массив
// {
//     int nul=0;
//     int first=1;

//     for (int i=0; i<=number+1;i++)
//     {

//     }
// }

