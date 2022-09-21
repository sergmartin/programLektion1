Console.Write("Введите свое имя: ");
var username = Console.ReadLine();

if ( username.ToLower() == "сергей")
{
    Console.WriteLine("Это же Серёга!!!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username + "!");
}