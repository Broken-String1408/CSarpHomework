int number = new Random().Next(100, 1000);
System.Console.WriteLine("Выпал рандом: " + number);

int first = number / 100;
int last = number % 10;
int result = first * 10 + last;
System.Console.WriteLine(result);
