//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите цифру больше 99");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
    Console.WriteLine("Нужно больше циферок, милорд"); 
else 
    {
    while (number > 99)
        number = number / 10;

    int result = number % 10;
    Console.WriteLine(result);
    }