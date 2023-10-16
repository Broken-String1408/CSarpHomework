/*
Внутри класса Answer напишите метод ShowCube, 
который принимает на вход число (N) и выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.
*/
System.Console.WriteLine("Enter number: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
System.Console.WriteLine($"{i} * {i} * {i} = {Math.Pow(i, 3)}");
}