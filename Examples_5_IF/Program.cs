Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower () == "masha")
{
    Console.WriteLine("Это Она");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
