Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Oh no, it's Maria again!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}