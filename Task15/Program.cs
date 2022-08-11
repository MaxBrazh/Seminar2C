// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
using static System.Console;

WriteLine("Введите цифру, обозначающую день недели от 1 до 7: ");
int DayofWeek = int.Parse(ReadLine());
    if(DayofWeek == 6 | DayofWeek == 7)
    {
        WriteLine("Выходной день");
    }
    else
    {
        WriteLine("Рабочий день");
    }