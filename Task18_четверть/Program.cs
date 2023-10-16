/*
18. Напишите программу, которая по заданному номеру четверти, показывает диапазон

возможных координат точек в этой четверти (x и y).
*/
Console.Clear();



System.Console.WriteLine("Введите номер четверти");

int numb = Convert.ToInt32(Console.ReadLine());



if (numb == 1)

System.Console.WriteLine("X > 0 и Y > 0");

else if (numb == 2)

System.Console.WriteLine("X < 0 и Y > 0");

else if (numb == 3)

System.Console.WriteLine("X < 0 и Y < 0");

else if (numb == 4)

System.Console.WriteLine("X > 0 и Y < 0");

else if (numb < 1 || numb > 4)

System.Console.WriteLine("Нет такой четверти");