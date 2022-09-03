// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int numberWrite = 2;
if (numberWrite <= number)
{
    while (numberWrite <= number)
    {
        Console.WriteLine(numberWrite);
        numberWrite = numberWrite + 2;
    }
}
else
{
    Console.WriteLine("Нет четных чисел в диапазоне от 1 до вашего числа");
}
