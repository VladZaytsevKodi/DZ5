// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();
Console.WriteLine("Введите колиество элементов массива: ");
int val = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите минимальное число элемента массива: ");
int minValue = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите максимальное число элемента массива: ");
int maxValue = int.Parse(Console.ReadLine()!);

double[] array = new double [val];
double max = 0;
double min = 0;
double difference = 0;
var r = new Random();
for (int i = 0; i < val; i++)
{
   array [i] = 1.0 * r.Next(minValue, maxValue + 1); 
   Console.Write($"{array[i]}, ");
}
min = array[0];
max = array[0];
for (int i = 0; i < val; i++)
{
       if (array[i] < min)
            min = array[i];
       if (array[i] > max)
            max = array[i];

}
difference = max - min;
Console.WriteLine();
Console.WriteLine("Max: " + max);
Console.WriteLine("Min: " + min);
Console.WriteLine("Мах-Мин= " + difference);




