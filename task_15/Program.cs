/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/


 Console.WriteLine ("Дни недели.");
      Console.WriteLine ("Введите день недели...");
      int dayofweek = int.Parse(Console.ReadLine());
      if (dayofweek == 6 || dayofweek == 7) 
      Console.WriteLine ("Выходной день.");
      else if (dayofweek <= 5) Console.WriteLine ("Будний день!");
      else if (dayofweek > 7) Console.WriteLine ("В неделе 7 дней!");