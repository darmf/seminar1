// Напишите программу, которая на вход принимает число и выдает,  является ли оно четным

Console.Write("введите число");
int numb = int.Parse(Console.ReadLine()!);
if(numb%2 == 0)
{
    Console.Write(" число четное");
}
else
{
    Console.Write(" число нечетное");
}

