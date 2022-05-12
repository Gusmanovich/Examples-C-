Console.Write("Ввведите ваше имя:   ");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
    Console.Write("Здравствуй, МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
