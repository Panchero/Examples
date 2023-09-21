Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша") //ToLower() - переводит символы вводимых слов в нижний регистр
{
     Console.WriteLine("Ура, Это же Маша!");
}
else
{
     Console.Write("Привет, ");
     Console.WriteLine(username);
}