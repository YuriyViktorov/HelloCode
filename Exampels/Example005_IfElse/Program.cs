Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == " маша")
{
    Console.WriteLine("Салют, МАША!");

}
else
{
    Console.Write("Здравствуйте, ");
    Console.WriteLine(username);
}

