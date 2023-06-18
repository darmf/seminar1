
// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее

Console.Write("введите первое число" );
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите второе число ");
int number2 = int.Parse(Console.ReadLine()!);
if(number1 > number2)
{
Console.WriteLine("первое число больше второго");
}
else
{
Console.WriteLine(" первое число меньше второго");
}