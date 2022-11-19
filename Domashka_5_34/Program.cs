// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


Console.Clear();
Console.WriteLine("Введите колиество элементов массива: ");
int val = int.Parse(Console.ReadLine()!);
int [] array = new int [val];
var r = new Random();
int СountEven = 0;
int minValue = 99;
int maxValue = 999;

for (int i = 0; i < val; i++)
    {
        array[i] = r.Next(minValue, maxValue + 1);
        if (array[i] % 2 == 0)
        СountEven++;
        Console.Write(array[i] + " ");
    }

    Console.WriteLine(); 
    Console.Write("Колиество четных чисел в массиве: " + СountEven);


