﻿// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int[,]array = new int[m,n];

void NewArray()
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j]= new Random().Next(1,10);
    }
  }
}

void PrintArray()
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i,j]+" ");
    }
    Console.WriteLine();
  }
}
double result = 0;
void Srednee()
{
    for (int i = 0; i < array.GetLength(1); i++)
  {
       for (int j = 0; j < array.GetLength(0); j++)
       {
        result = result + array[j,i];
       }
       result=result/m;
      Console.WriteLine($"srednee arifmetiheskoe = {result}");
      result = 0;
  }
}

NewArray();
PrintArray();
Srednee();

