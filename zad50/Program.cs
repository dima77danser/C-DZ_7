// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента или же указание,
//  что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

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
int count = 0;
void SearchNum()
{
    for (int i = 0; i < array.GetLength(0); i++)
  {
    
     for (int j = 0; j < array.GetLength(1); j++)
       {
          if (array[i,j]==num)
         {
            Console.WriteLine($"позиция числа:  ({i},{j})");
            count++;
         }
       }
  }
  if (count ==0)
  {
    Console.WriteLine("Такого числа нет в массиве");
  }       
}


NewArray();
PrintArray();
SearchNum();