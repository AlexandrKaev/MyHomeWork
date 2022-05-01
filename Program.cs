// Задача 1. Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше.
/*

Console.WriteLine("Integer number1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Integer number2");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 < num2)
{
    Console.WriteLine(num2 + " is more " + num1);
}

else
{
Console.WriteLine(num1 + " is more " + num2);    
}

// Задача 2. Напишите программу, которая принимает на вход три чиста и выдает максимальное из них.

Console.WriteLine("Integer number1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Integer number2");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Integer number3");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.WriteLine("Maximum number - " + max);

// Задача 3.Напишите программу, которая на вход принимает число и выдает, является ли оно четным (делится на два без остатка)

Console.WriteLine("Integer number1");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
 Console.WriteLine("The number is even");
}
else
{
   Console.WriteLine("The number is not even"); 
}
*/

// Задача 4. Напишите программу, которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N

Console.WriteLine("Integer number");
int num = Convert.ToInt32(Console.ReadLine());
int current = 1;

while (current <= num)
{
if (current % 2 == 0)
{
 Console.WriteLine(current + " ");
 current++;
}
}
