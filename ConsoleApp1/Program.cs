// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("------ Задача 2 -------\n");
Console.Write("Введите a: ");
int a =  Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b: ");
int b =  Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{int.Max(a,b)}");

Console.Write("------ Задача 4 -------\n");
Console.Write("Введите a: ");
int a1 =  Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b: ");
int b1 =  Convert.ToInt32(Console.ReadLine());
Console.Write("Введите с: ");
int с1 =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{int.Max(int.Max(a1,b1),int.Max(с1,b1))}");

Console.WriteLine("------ Задача 6 -------\n");
Console.Write("Введите a: ");
int a2 =  Convert.ToInt32(Console.ReadLine());
if (a2 % 2 != 0)
{
    Console.WriteLine("нет");
}
else
{
    Console.WriteLine("да");    
}

Console.WriteLine("------ Задача 8 -------\n");
Console.Write("Введите a: ");
int a3 =  Convert.ToInt32(Console.ReadLine());
string b3;
for (int i = 1; i <= a3; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + (i == a3?"":", "));
    }
}

Console.WriteLine("------ Задача 7 -------\n");
Console.Write("Введите a: ");
int a4 =  Convert.ToInt32(Console.ReadLine());
int b4;
if (a4 < 10)
    Console.WriteLine("нет");
else
{
    do
    {
        b4 = a4 % 10;
        a4 /= 10;
    } while (a4 >= 10);
    Console.WriteLine(b);
}
*/


Console.WriteLine("------ Задача 10 -------\n");
Console.Write("Введите a: ");
int a5 =  Convert.ToInt32(Console.ReadLine());
int b5;
if (a5 < 99 || a5 > 999)
    Console.WriteLine("нет");
else
{
    do
    {
        b5 = a5 % 10;
        a5 /= 10;
    } while (a5 >= 10);
    Console.WriteLine(b5);
}

Console.WriteLine("------ Задача 13 -------\n");
Console.Write("Введите a: ");
int a6 =  Convert.ToInt32(Console.ReadLine());
int b6;
if (a6 < 99)
    Console.WriteLine("третьей цифры нет");
else
{
    do
    {
        b6 = a6 % 10;
        a6 /= 10;
    } while (a6 >= 100);
    Console.WriteLine(b6);
}

Console.WriteLine("------ Задача 13 -------\n");
Console.Write("Введите a: ");
int a7 =  Convert.ToInt32(Console.ReadLine());
switch (a7)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        Console.WriteLine("нет");
        break;
    case 6:
    case 7:
        Console.WriteLine("да");
        break;
}

Console.WriteLine("------ Задача необязательная 1 -------");
Console.Write("Введите a: ");
string a8 =  Console.ReadLine();
string temp = "";

if (a8.Length < 2)
{
    Console.WriteLine("нет");
}
else
{
    for (int i = 0; i < a8.Length; i++)
    {
        if (i != 1)
        {
            temp += a8[i];
        }
    }
    Console.WriteLine(temp);
}


Console.WriteLine("------ Задача необязательная 2 -------");
Console.Write("Введите a: ");
int a9 =  Convert.ToInt32(Console.ReadLine());
if (a9 < 1)
{
    Console.WriteLine("нет Программистов");
} else switch (a9 % 10)
{
    case 1 when (a9 % 100 < 10 || a9 % 100 > 20):
        Console.WriteLine($"{a9} Программист");
        break;
    case 2 or 3 when (a9 % 100 < 10 || a9 % 100 > 20):
        Console.WriteLine($"{a9} Программиста");
        break;
    default:
    {
        if ((a9 % 10 > 3) || (a9 % 100 > 10 || a9 % 100 < 20))
        {
            Console.WriteLine($"{a9} Программистов");
        }
        break;
    }
}