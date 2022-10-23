//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет


string mes;
Console.WriteLine("День недели: 6, 7, 1");
string day = Console.ReadLine();
  switch (day)
   {  case "6": mes = "да"; break;
      case "7": mes = "да"; break;
      default:   mes = "нет"; break;
   }
Console.WriteLine(mes);