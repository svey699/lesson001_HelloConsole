//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да


{
int[] nums = {1, 2, 8, 2, 1};
bool number = false;
for (int i = 0; i < nums.Length; i++)
if (nums [i] == nums[nums.Length-1])
	number = true;
if (number)
	 Console.WriteLine($"Число: {nums} - является палиндромом.");
else 
     Console.WriteLine($"Число: {nums} - не является палиндромом.");
}
