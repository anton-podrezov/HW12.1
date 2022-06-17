using System;
using System.Collections.Generic;
using HW12._1;

User user = new User();


Console.WriteLine("Введите свое имя:");
user.Name = Console.ReadLine();

Console.WriteLine("Введите свой Логин:");
user.Login = Console.ReadLine();

Console.WriteLine("Подключен ли у вас премиум АККАУНТ? Если ДА то введите КЛЮЧ ПАРОЛЬ! Если НЕТ нажмите на любую цыфру");

var premium = int.Parse(Console.ReadLine());


switch (premium)
{
    case 1111:
        user.IsPremium = true;
        break;

    case 2222:
        user.IsPremium = true;
        break;

    case 3333:
        user.IsPremium = true;
        break;

    default:
        user.IsPremium = false;
        break;
}


if (user.IsPremium)
{
    Console.WriteLine($"Вы вошли в Аккаут под логином {user.Login}");
    Console.WriteLine($"Притной игры {user.Name}");
}

else
    ShowAds();



static void ShowAds()
{
    Console.WriteLine("\n\tПосетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
    // Остановка на 1 с
    Thread.Sleep(1000);

    Console.WriteLine("\tКупите подписку на МыКомбо и слушайте музыку везде и всегда.");
    // Остановка на 2 с
    Thread.Sleep(2000);

    Console.WriteLine("\tОформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
    // Остановка на 3 с
    Thread.Sleep(3000);
}