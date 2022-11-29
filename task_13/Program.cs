/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

int number = ReadInt("Введите число: ");

if (number>99 || number<-99)
{
    do {number = number / 10;}
    while (number>999 || number<-999);
    if(number<0)
    {
        number = number * (-1); 
    }
    Console.WriteLine(number%10);
}
else 
{
    Console.WriteLine("!!! Это двухзначное число, введи трехзначное !!!");
}


int ReadInt (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}