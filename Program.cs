void Zadacha47()
{
// Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами, округлёнными до одного знака.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
Random random = new Random();
int m = 3;
int n = 4;
double[,] array = new double[m, n]; 
FillArray (array);
PrintArray(array);

void FillArray(double[,] array)
{
    Random random = new Random();
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    for (int i = 0; i < m; i++)
    { 
    for (int j = 0; j < n; j++)
    {
      array[i, j] = Math.Round(random.NextDouble() *10-5, 1);
    }
    }
}
void PrintArray(double[,] array)
{
    Random random = new Random();
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    for (int i = 0; i < m; i++)
    {
    for (int j = 0; j < n; j++)
    {
      Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
    }
}
}
Zadacha47();

void Zadacha50()
{
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
// 17 -> такого числа в массиве нет
Console.WriteLine();
Random random = new Random();
int m = 3;
int n = 4;
int[,] array = new int[m, n]; 
FillArray (array);
PrintArray(array);
Console.WriteLine ("введите номер строки:");
int numberRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("введите номер столбца:");
int numberColumn = Convert.ToInt32(Console.ReadLine());
Element(array);
}

void Element(int[,] array)
{
   int element;
   int numberRow = 1;
   int numberColumn = 1;
   int m = array.GetLength(0);
   int n = array.GetLength(1);
   if (numberRow <= m && numberColumn <= n)
   {
      element = array[numberRow - 1, numberColumn - 1];
      Console.WriteLine($"Элемент массива = {element}");
   }
   else
   {
      Console.WriteLine("Такого числа в массиве нет");
   }
}

void Zadacha52()
{
// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.WriteLine();
Random random = new Random();
int m = 3;
int n = 4;
int[,] array = new int[m, n]; 
FillArray (array);
PrintArray(array);
Average(array);
}
void FillArray(int[,] array)
{
    Random random = new Random();
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    for (int i = 0; i < m; i++)
    { 
    for (int j = 0; j < n; j++)
    {
      array[i, j] = random.Next(1, 11);
    }
    }
}
void PrintArray(int[,] array)
{
    Random random = new Random();
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    for (int i = 0; i < m; i++)
    {
    for (int j = 0; j < n; j++)
    {
      Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
    }
}
void Average(int[,] array)
{
    int index = 1;
    double average = 0;
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    for (int j = 0; j < n; j++)
    {
      double sum = 0;
      for (int i = 0; i < m; i++)
      {
        sum += array[i, j];
        average = Math.Round(sum / m, 1);
      }
      Console.WriteLine($"Среднее арифметическое столбца {index} = {average}");
      index++;
    }
}

Zadacha50();
Zadacha52();