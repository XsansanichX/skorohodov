﻿//Задание 3: считываем два числа и выводим в консоль сумму;

Console.WriteLine("enter first number");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter second number");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(firstNumber + secondNumber + "=" + firstNumber + "+" + secondNumber);

Console.ReadKey();