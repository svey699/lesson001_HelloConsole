﻿//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

int [] num = {1,4,2,1, 2};
bool nums = true;
for(int i=0;i<num.Length/2;i++){
    if(num[i]!=num[num.Length-1-i])
    nums=false;
}
if(nums)
Console.WriteLine("число является палиндромом");
 else
Console.WriteLine("число не является палиндромом");


