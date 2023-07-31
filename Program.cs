// Task 2. Напишите программу, которая на вход принимает два числа
// и выдаёт какое число большее, а какое меньшее.
/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2) Console.WriteLine(num1);
else Console.WriteLine(num2);
*/
// Task 4. Напишите программу, которая принимает на вход три числа и выдаёт
// максимальное из этих чисел.
/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine(num1);
}
else if(num2 > num3)
{
    Console.WriteLine(num2);
}
else
{
    Console.WriteLine(num3);
}
*/
// Task 6. Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a % 2 == 0) Console.WriteLine("Yes!");
else Console.WriteLine("No!");
*/
// Task 8. Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

int current = 0;

while (current <= a)
{
    Console.Write(current + " ");
    current = current + 2;
}