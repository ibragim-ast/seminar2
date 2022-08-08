int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int digit1 = (number / 100) * 10 + number % 10;

Console.Write(digit1);


