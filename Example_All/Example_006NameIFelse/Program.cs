Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine(); 

if(username.ToLower() == "влад")
{
    Console.WriteLine("Ура, Это же Влад!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}

    