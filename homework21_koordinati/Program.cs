//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

 int x1 = coordinate ("x", "A");
 int y1 = coordinate ("y", "A");
 int z1 = coordinate ("z", "A");
 int x2 = coordinate ("x", "B");
 int y2 = coordinate ("y", "B");
 int z2 = coordinate ("z", "B");
int coordinate(string PlName, string pointName)
{
    Console.Write($"Введите координату {PlName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}
 Console.WriteLine (Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2)));
