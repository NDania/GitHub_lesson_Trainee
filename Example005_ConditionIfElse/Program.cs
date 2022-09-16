Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "dania")
{
    Console.WriteLine("Привет, красотка!");
}
else
{
    Console.Write("Привет, дурачок! ");
    Console.WriteLine(username);
}