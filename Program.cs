Console.Write("Введите количество строк в двумерном массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в двумерном массиве: ");
int cols = Convert.ToInt32(Console.ReadLine());
int [,] GetMatrix (int rows, int cols, int minValue, int maxValue)
{
  int[,] matrix = new int[rows,cols];
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < cols; j++)
    {
      matrix[i,j] = new Random().Next(minValue, maxValue + 1);
    }
  }
  return matrix;
}
void PrintMatrix(int [,] matrix)
{
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < cols; j++)
    {
      Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
  }
}
int [,] array2D = GetMatrix(rows, cols, 0, 50);
PrintMatrix(array2D);
for (int j = 0; j < cols; j++)
{
  double mediumA = 0;
  for (int i = 0; i < rows; i++)
  {
    mediumA = mediumA + array2D[i,j];
  }
  mediumA = mediumA / rows;
  Console.Write($"Среднее арифметическое столбца {j} - {Math.Round(mediumA, 2)} ");
}