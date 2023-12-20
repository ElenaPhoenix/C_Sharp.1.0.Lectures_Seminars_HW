int Factorial(int n)
{
    // 1!=1
    // 0!=1
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}

Console.WriteLine(Factorial(5)); // не для больших чисел, переполнение. Можно в таких случаях использовать double