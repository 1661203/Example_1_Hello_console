Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "наталья")
{
    Console.WriteLine("Ура, это же сама Наталья!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
