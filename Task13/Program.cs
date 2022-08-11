// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
using static System.Console;

int digitCount(int number)
{
    int i = 0;
    while (number != 0)
    {
        number /= 10;  
        i++;
    }
    return i;
}

int MyPow(int a, int n)
{
int myresult = 1;
for (int i = 0; i<n; i++)
myresult *= a;
return myresult;
}

WriteLine("Введите целое число: ");
int number = int.Parse(ReadLine());
int [] array = new int [3];
int i = 0;
int razryad = digitCount(number);
if (number >= 100)
{
while (i < 3)
{
array [i] = (number %  MyPow(10, razryad) ) / MyPow(10, razryad-1);
razryad--;
i++;
}
WriteLine($"Третья цифра числа: {array[2]}");
}
else
WriteLine("Число не трехзначное, третьей цифры нет!");