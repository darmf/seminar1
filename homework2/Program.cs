// Напишите программу, которая принимает на вход 3 числа и выдает максимальное из них

Console.Write("введите первое число ");
int numb1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("введите второе число");
int numb2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("введите третье число");
int numb3 = int.Parse(Console.ReadLine()!);

int max = 0;

if(numb1 > max)
{
   max = numb1;
}
if(numb2 > max)
{
    max = numb2;
}
if(numb3 > max)
{
    max = numb3;
}

Console.WriteLine($"Самое большое число — {max}");



