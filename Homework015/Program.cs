//Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

Console.WriteLine("Введите числовое значение дня недели");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 6 && number > 0)
    Console.WriteLine("Работай, программист, солнце еще высоко!");
else if (number > 7 || number < 1)
    Console.WriteLine("Нет такого дня недели");
else 
    Console.WriteLine("Ты заслужил выходной");
    
