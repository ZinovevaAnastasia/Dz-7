// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
int[,] matrix = new int[rows, columns];
Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
 {
   for (int j = 0; j < matrix.GetLength(1); j++)
   {
    matrix[i, j] = rnd.Next(min, max + 1);
   }
 }
return matrix;
}

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j], 6}");
    }
    Console.WriteLine();
  }
}

Console.WriteLine("введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array);
if (n > array.GetLength(0) || m > array.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {array[n-1,m-1]}");
}
