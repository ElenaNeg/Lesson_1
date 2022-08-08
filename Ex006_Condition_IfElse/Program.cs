/*
Console.Write ("Введите имя пользователя: ");
string username = Console.ReadLine( );

if (username == "Маша")
{
    Console.WriteLine ("Ура, это же МАША!");
}
else
{
    Console.Write ("Привет, ");
    Console.WriteLine (username);
}

*/
/*
Если написать имя с маленькой буквы, то по особенному любимчика не будут приветствовать. Поэтому запишем по новому 
*/ 

Console.Write ("Введите имя пользователя: ");
string username = Console.ReadLine( );

if (username.ToLower() == "маша")
{
    Console.WriteLine ("Ура, это же МАША!");
}
else
{
    Console.Write ("Привет, ");
    Console.WriteLine (username);
}