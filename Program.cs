﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= userNumber; i++)
{
    int result = i * i * i;
    if(i == userNumber)
    {
       Console.Write(result);
    }
    else
    {
        Console.Write(result + ", ");
    }

}