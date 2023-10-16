/*
Внутри класса Answer напишите метод DistanceBetweenPoints, 
который принимает на вход координаты двух точек pointA и pointB в виде массива целых чисел,
и возвращает расстояние между ними в 3D пространстве.
*/

Console.Clear();

System.Console.Write("Задай координату точки A x:");

int userAX = int.Parse(Console.ReadLine());

System.Console.Write("Задай координату точки A y:");

int userAY = int.Parse(Console.ReadLine());

System.Console.WriteLine("Задай координату точки A z: ");

int userAZ = int.Parse(Console.ReadLine());



System.Console.Write("Задай координату точки B x:");

int userBX = int.Parse(Console.ReadLine());

System.Console.Write("Задай координату точки B y:");

int userBY = int.Parse(Console.ReadLine());

System.Console.WriteLine("Задай координату точки B z: ");

int userBZ = int.Parse(Console.ReadLine());



//int sqrX = (userBX - userAX) * (userBX - userAX);

double sqrX = Math.Pow(userBX - userAX, 2); //Math.Pow(а, 2) функция возводит в степень (переменная, в какую степень надо возвести)

double sqrY = Math.Pow(userBY - userAY, 2);

double sqrZ = Math.Pow(userBZ - userAZ, 2);

double sqrt = Math.Sqrt(sqrX + sqrY + sqrZ); // Math.Sqrt(sqrX + sqrY) выводит квадратный корень из переменной в скобочках

System.Console.WriteLine(Math.Round(sqrt, 2)); // Math.Round(sqrt, 2) округляет десятичное число (переменная, сколько знаков после запятой оставить)


// double squareX = Math.Pow(pointB[0] - pointA[0], 2);
// double squareY = Math.Pow(pointB[1] - pointA[1], 2);
// double squareZ = Math.Pow(pointB[2] - pointA[2], 2);
// double result = Math.Sqrt(squareX + squareY + squareZ);
// return result;