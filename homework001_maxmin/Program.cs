//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

int a = -9, b = -3;
int max = a;
int min = b;

if (a > max) max = a;
if (b > max) max = b;
if (a < max) min = a;
if (b < max) min = b;


Console.Write("max = ");
Console.WriteLine(max); 
Console.Write("min = ");
Console.WriteLine(min); 
 