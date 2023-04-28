// See https://aka.ms/new-console-template for more information

Console.Write("------ Задача 2 -------\n");
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

Console.Write("------ Задача 6 -------\n");
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

Console.Write("------ Задача 8 -------\n");
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

Console.Write("------ Задача 7 -------\n");
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