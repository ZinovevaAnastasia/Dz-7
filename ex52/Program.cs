//Задача 52. Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.

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

int[,] array = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array);
Console.WriteLine("Среднее арифметическое каждого столбца матрицы:");
for (int j = 0; j < array.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        avarage = (avarage + array[i, j]);
    }
    avarage = avarage / 3;
    double result = Math.Round(avarage, 2, MidpointRounding.ToZero);
    Console.Write(result + "; ");
}
Console.WriteLine();
