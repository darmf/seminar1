// Напишите программу,которая на вход принимает чсило N, а на выходе показывает все четные числа от 1 до  N

Console.Write("введите число N" );
 int number1 = int.Parse( Console.ReadLine()!);

int number2 = 2;

if(number1 > 1)
{
    while(number2 <= number1)
    {
        Console.Write(number2 + " ");
        number2 = number2 + 2;
    }
}