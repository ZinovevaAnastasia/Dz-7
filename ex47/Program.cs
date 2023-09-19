// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

double[,] CreateMatrixRndDouble(int rows, int columns, int min, int max)
{
  double[,] matrix = new double[rows, columns]; 
  Random rnd = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
     matrix[i, j] = rnd.NextDouble() * (max - min) + min;
    }
  }
   return matrix;
}

void PrintMatrix(double[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j], 7:F2}");
    }
    Console.WriteLine();
  }
}

double[,] array2d = CreateMatrixRndDouble(3, 4, -100, 100);
PrintMatrix(array2d);
