//Здравствуйте,Станислав. Поспешила в предыдущей домашке,поэтому не подумала,что точки могут вообще не пересечься(﻿

// Задача 1.

System.Console.Write("Введите кол-во элем-в массива: ");
int num = Convert.ToInt32(Console.ReadLine());
 int[] array = new int[num];
 int count =0;
for (int i =0; i<array.Length; i++)
{
    array[i] = new Random().Next(100,1000);
}
  for (int i =0; i<array.Length; i++)
{
    System.Console.Write($"{array[i]} ");
    if (array[i] % 2 == 0) count++;
 } 
 System.Console.WriteLine();
System.Console.Write($"Кол-во четных элем-в массива: {count}");


// Задача 2.

System.Console.Write("Введите кол-во элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];
int res = 0;
for (int i = 0; i<array.Length; i++)
{
    array[i] = new Random().Next(1,11);
    System.Console.Write($"{array[i]} ");
}
for (int i = 0; i<array.Length; i+=2)
{
  res = res + array[i];
}
System.Console.WriteLine();
System.Console.WriteLine(res);

// Задача 3.

Console.Write("Введите кол-во элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());
double[] array = new double[num];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble();
    Console.Write($"{Math.Round(array[i],3)} ");
}
Console.WriteLine();
double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= max) max = array[i];
    if (min >= array[i]) min = array[i];
}
double result = Math.Round(max,3) -Math.Round(min,3);
System.Console.WriteLine(Math.Round(max,3)+ "-"+ Math.Round(min,3) + "=" + Math.Round(result,3));
