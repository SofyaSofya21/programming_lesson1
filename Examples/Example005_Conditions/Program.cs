Console.WriteLine("Введите Ваше имя");
string username = Console.ReadLine();
if (username.ToLower() == "соня")
{
    Console.WriteLine("Ура! Привет, Сонечка!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}