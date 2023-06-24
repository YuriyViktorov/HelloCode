Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "mery")
{
    Console.WriteLine("Салют, МАША!");

}
else
{
    Console.Write("Здравствуйте, ");
    Console.Write(username);
    Console.Write("!");
}

