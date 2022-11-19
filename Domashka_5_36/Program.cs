//  Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();
Console.WriteLine("Введите колиество элементов массива: ");
int val = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите минимальное число элемента массива: ");
int minValue = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите максимальное число элемента массива: ");
int maxValue = int.Parse(Console.ReadLine()!);

double SumOdd = 0;
double[] array = new double [val];
var r = new Random();
for (int i = 0; i < val; i++)
{
   array [i] = 1.0 * r.Next(minValue, maxValue + 1); 
   Console.Write($"{array[i]}, ");
}

for (int i = 0; i < val; i+=2)
{    
    SumOdd =  SumOdd + array[i];    
}

Console.WriteLine(); 
Console.WriteLine("Сумма на нечетных позициях " + SumOdd); 
