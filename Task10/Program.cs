// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
using static System.Console;

WriteLine("Введите целое трёхзначное число: ");
int number = int.Parse(ReadLine());
int [] array = new int[2];
int i = 0;
int razryad = 1;
if (number >= 100 && number <= 999)
{
while (i < 2)
{
array [i] = (number / razryad) % razryad;
razryad = razryad * 10;
i++;
}
WriteLine($"Вторая цифра числа: {array[1]}");
}
else
WriteLine("Число не трехзначное!");