Console.WriteLine("Введите целое положительное число");
int numberB = Convert.ToInt32(Console.ReadLine());
int numberA = 1;
       
if (numberB==1)
{
    Console.WriteLine("положительные четные числа от 1 до введенного числа отсутствуют");
}
while(numberA<numberB)
{
    Console.WriteLine(numberA+1);
    numberA+=2;
}
    Console.WriteLine(" это все четные числа от 1 до введенного числа");