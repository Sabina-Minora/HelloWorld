Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "минора")
{
    Console.WriteLine("Ура, это же МЭЛ!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}