/*
17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0

и выдаёт номер четверти плоскости, в которой находится эта точка.

x=34; y=-30 -> 4

x=2; y=4-> 1

x=-34; y=-30 -> 3
*/
Console.Clear();



System.Console.Write("задай координту точки X: ");

int userX = int.Parse(Console.ReadLine());

System.Console.Write("задай координту точки Y: ");

int userY = int.Parse(Console.ReadLine());



if (userX > 0 && userY > 0)

{

System.Console.WriteLine("точка находится в 1 четверти");

}

if (userX < 0 && userY > 0)

{

System.Console.WriteLine("точка находится во 2 четверти");

}

if (userX < 0 && userY < 0)

{

System.Console.WriteLine("точка находится в 3 четверти");

}

if (userX > 0 && userY < 0)

{

System.Console.WriteLine("точка находится в 4 четверти");

}

if (userX == 0 || userY == 0)

{

System.Console.WriteLine("точка находится на оси координат");

}