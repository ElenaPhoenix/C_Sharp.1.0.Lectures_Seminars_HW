Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if (username.ToLower() == "елена")
{
    Console.WriteLine("Привет, самая обаятельная и привлекательная!");
}
else

{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
