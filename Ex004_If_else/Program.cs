Console.Write("Ввведите ваше имя:   ");
string username = Console.ReadLine();
if (username.ToLower() == "маша") // функция ToLower() преобразует все символы строки в нижний регистр
{
    Console.Write("Здравствуй, МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
